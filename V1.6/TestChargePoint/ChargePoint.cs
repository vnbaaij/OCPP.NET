using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

using OCPP.V16;
using OCPP.V16.Core;
using OCPP.V16.FirmwareManagement;
using OCPP.V16.RemoteTrigger;

namespace TestChargePoint
{
    public static class ChargePoint
    {
        private static ClientWebSocket _socket;

        private static readonly BlockingCollection<string> _keyQueue = new();
        private static readonly BlockingCollection<(Guid id, OcppOperation action)> _operationQueue = new();

        private static CancellationTokenSource _receiveTokenSource;
        private static CancellationTokenSource _sendTokenSource;

        private static int _heartbeatInterval = 300;
        private static DateTime _csmsDateTime;

        public static WebSocketState State
        {
            get => _socket?.State ?? WebSocketState.None;
        }

        public static async Task StartAsync(string wsUri) => await StartAsync(new Uri(wsUri));

        public static async Task StartAsync(Uri wsUri)
        {
            Console.WriteLine($"Connecting to Central System ({wsUri})...");

            _receiveTokenSource = new CancellationTokenSource();
            _sendTokenSource = new CancellationTokenSource();

            try
            {
                _socket = new ClientWebSocket();
                //_socket.Options.AddSubProtocol("ocpp2.0.1");
                _socket.Options.AddSubProtocol("ocpp1.6");
                await _socket.ConnectAsync(wsUri, CancellationToken.None);
                Console.WriteLine("- Connected!");

                _ = Task.Run(() => FromChargePointAsync().ConfigureAwait(false));
                _ = Task.Run(() => FromCentralSystemAsync().ConfigureAwait(false));
            }
            catch (OperationCanceledException)
            {
                // normal upon task/token cancellation, disregard
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex}");
            }
        }

        public static async Task StopAsync()
        {
            Console.WriteLine($"\nClosing connection");
            _sendTokenSource.Cancel();
            if (_socket == null || _socket.State != WebSocketState.Open) return;

            // close the _socket first, because ReceiveAsync leaves an invalid _socket (state = aborted) when the token is cancelled
            var timeout = new CancellationTokenSource(5000);

            try
            {
                // after this, the _socket state will change to CloseSent
                await _socket.CloseOutputAsync(WebSocketCloseStatus.NormalClosure, "Closing", timeout.Token);
                // now we wait for the server response, which will close the _socket
                while (_socket.State != WebSocketState.Closed && !timeout.Token.IsCancellationRequested) ;
            }
            catch (OperationCanceledException)
            {
                // normal upon task/token cancellation, disregard
            }
            
            _receiveTokenSource.Cancel();
        }


        public static void QueueOperation(string operation) => _keyQueue.Add(operation);

        private static async Task FromChargePointAsync()
        {
            var cancellationToken = _sendTokenSource.Token;
            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    if (_keyQueue.TryTake(out var key))
                    {

                        switch (key)
                        {
                            case "1":
                                await SendBootNotificationAsync();
                                break;
                            case "2":
                                await SendAuthorizeAsync();
                                break;
                            case "5":
                                await SendHeartbeatAsync();
                                break;
                            case "7":
                                await SendDiagnosticsStatusNotificationAsync();
                                break;
                            case "8":
                                await SendDataTransferAsync();
                                break;
                            case "9":
                                await SendStatusNotificationAsync();
                                break;
                            case "r":
                                _ = Task.Delay(5000);
                                break;
                        }
                    }
                }
                catch (OperationCanceledException)
                {
                    // normal upon task/token cancellation, disregard
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex}");
                }
            }
        }

        private static async Task FromCentralSystemAsync()
        {
            var cancellationToken = _receiveTokenSource.Token;
            try
            {
                var buffer = WebSocket.CreateClientBuffer(4096, 4096);
                while (_socket.State != WebSocketState.Closed && !cancellationToken.IsCancellationRequested)
                {
                    var result = await _socket.ReceiveAsync(buffer, cancellationToken);
                    // if the token is cancelled while ReceiveAsync is blocking, the _socket state changes to aborted and it can't be used
                    if (!cancellationToken.IsCancellationRequested)
                    {
                        // the server is notifying us that the connection will close; send acknowledgement
                        if (_socket.State == WebSocketState.CloseReceived && result.MessageType == WebSocketMessageType.Close)
                        {
                            Console.WriteLine($"\nAcknowledging connection will close notification from server");
                            _sendTokenSource.Cancel();
                            await _socket.CloseOutputAsync(WebSocketCloseStatus.NormalClosure, "Acknowledge closing connection", CancellationToken.None);
                        }

                        if (_socket.State == WebSocketState.Open && result.MessageType != WebSocketMessageType.Close)
                        {
                            OcppMessage message = new(buffer.Take(result.Count).ToArray());
                            if (_operationQueue.TryTake(out var operation))
                            {
                                if (operation.id == message.MessageId)
                                {
                                    message.Action = operation.action;
                                }
                            }

                            IResponse response;

                            switch (message.Action)
                            {
                                case OcppOperation.BootNotification:
                                    response = message.Parse<BootNotificationResponse>();
                                    await HandleBootNotificationAsync(response as BootNotificationResponse);
                                    break;
                                case OcppOperation.Authorize:
                                    response = message.Parse<AuthorizeResponse>();
                                    HandleAuthorize(response as AuthorizeResponse);
                                    break;
                                case OcppOperation.ClearCache:
                                    response = message.Parse<ClearCacheResponse>();
                                    await HandleClearCacheAsync(message);
                                    break;
                                case OcppOperation.Heartbeat:
                                    response = message.Parse<HeartbeatResponse>();
                                    HandleHeartbeat(response as HeartbeatResponse);
                                    break;

                                case OcppOperation.TriggerMessage:
                                    response = message.Parse<TriggerMessageResponse>();
                                    await HandleTriggerMessageAsync(message);
                                    break;
                                case OcppOperation.DataTransfer:
                                    response = message.Parse<DataTransferResponse>();
                                    HandleDataTransfer(response as DataTransferResponse);
                                    break;
                                case OcppOperation.DiagnosticsStatusNotification:
                                case OcppOperation.FirmwareStatusNotification:
                                case OcppOperation.StatusNotification:
                                case OcppOperation.MeterValues:
                                case OcppOperation.UpdateFirmware:
                                    response = message.Parse<EmptyResponse>();
                                    Program._waitloopTokenSource.Cancel();
                                    break;
                            }
                        }
                    }
                }
                Console.WriteLine($"Ending processing loop in state {_socket.State}");
            }
            catch (OperationCanceledException)
            {
                // normal upon task/token cancellation, disregard
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex}");
            }
            finally
            {
                _sendTokenSource.Cancel();
                _socket.Dispose();
                _socket = null;
            }
        }

        private static async Task SendAuthorizeAsync()
        {
            var request = new AuthorizeRequest
            {
                IdTag = "3060044040003000853"
            };

            await SendAsync(request);
        }

        private static async Task SendBootNotificationAsync()
        {
            var request = new BootNotificationRequest
            {
                ChargePointVendor = "Baaijte",
                ChargePointModel = "QuickCharger 11+",
                ChargePointSerialNumber = "bqc.001.20.1",
                ChargeBoxSerialNumber = "bqc.001.20.1.01",
                FirmwareVersion = "3.11.20",
                MeterType = "Landis+Gyr E350",
                MeterSerialNumber = "4530303035303031363935303633303135"
            };

            await SendAsync(request);
        }

        private static async Task SendClearCacheAsync(ClearCacheResponse response, bool accepted)
        {
            if (accepted)
                response.Status = ClearCacheResponseStatus.Accepted;
            else
                response.Status = ClearCacheResponseStatus.Rejected;

            await SendAsync(response);
        }

        private static async Task SendDataTransferAsync()
        {
            var request = new DataTransferRequest
            {
                VendorId = "",
                Data = "Just some random extra data",
                MessageId = ""

            };

            await SendAsync(request);
        }

        private static async Task SendDiagnosticsStatusNotificationAsync()
        {

            var request = new DiagnosticsStatusNotificationRequest
            {
                Status = DiagnosticsStatusNotificationRequestStatus.Idle

            };

            await SendAsync(request);
        }

        private static async Task SendFirmwareStatusNotificationAsync()
        {
            var request = new FirmwareStatusNotificationRequest
            {
                Status = FirmwareStatusNotificationRequestStatus.Idle

            };

            await SendAsync(request);
        }

        private static async Task SendHeartbeatAsync()
        {
            var request = new HeartbeatRequest();

            await SendAsync(request);
        }

        private static Task SendMeterValuesAsync()
        {
            throw new NotImplementedException();
        }

        private static async Task SendStatusNotificationAsync()
        {
            var request = new StatusNotificationRequest
            {
                ConnectorId = 1,
                ErrorCode = StatusNotificationRequestErrorCode.NoError,
                Info = "Bla",
                Status = StatusNotificationRequestStatus.Available,
                Timestamp = DateTime.UtcNow,
                VendorErrorCode = "My Vendor ErrorCode",
                VendorId = "My Vendor Id"

            };

            await SendAsync(request);
        }

        private static void HandleAuthorize(AuthorizeResponse response)
        {
            Console.WriteLine($"Authorization status: {response.IdTagInfo.Status}.");
            Program._waitloopTokenSource.Cancel();
        }

        private static async Task HandleBootNotificationAsync(BootNotificationResponse response)
        {
            //BootNotificationResponse response = ProcessResponseMessage<BootNotificationResponse>(message);

            if (response.Interval != 0)
                _heartbeatInterval = response.Interval;

            Console.WriteLine($"BootNotification {response.Status}.");
            switch (response.Status)
            {
                case BootNotificationResponseStatus.Accepted:
                    _csmsDateTime = response.CurrentTime;

                    Console.WriteLine($"- Heartbeat interval: {_heartbeatInterval / 60} min(s)");
                    Console.WriteLine($"- Central System date/time: {_csmsDateTime} (UTC)\n");
                    break;
                case BootNotificationResponseStatus.Rejected:
                    Console.WriteLine($"- Waiting {response.Interval} seconds before reattempt");
                    Thread.Sleep(response.Interval * 100);
                    await SendBootNotificationAsync();
                    break;
                case BootNotificationResponseStatus.Pending:

                    //await Receive<TriggerMessageRequest, TriggerMessageResponse>();
                    break;
            }
            Program._waitloopTokenSource.Cancel();
        }

        private static async Task HandleClearCacheAsync(OcppMessage message)
        {
            ClearCacheResponse response = message.Parse<ClearCacheResponse>();

            ConsoleKeyInfo cki;

            Console.ResetColor();
            Console.WriteLine("ClearCache operation received. ");
            Console.WriteLine("\tPress 'a' to accept or any other key reject");
            Console.Write("\r\nSelect an action: ");

            cki = Console.ReadKey();

            bool status = cki.KeyChar == 'a';
            await SendClearCacheAsync(response, status);
            Program._waitloopTokenSource.Cancel();
        }

        private static void HandleDataTransfer(DataTransferResponse response)
        {
            Console.WriteLine($"DataTransfer status: {response.Status}.");
            Program._waitloopTokenSource.Cancel();
        }

        private static void HandleHeartbeat(HeartbeatResponse response)
        {
            _csmsDateTime = response.CurrentTime;

            Console.WriteLine($"- Central System date/time: {_csmsDateTime} (UTC)\n");
            Program._waitloopTokenSource.Cancel();
        }

        private static async Task HandleTriggerMessageAsync(OcppMessage message)
        {
            TriggerMessageResponse response = message.Parse<TriggerMessageResponse>();

            ConsoleKeyInfo cki;

            Console.ResetColor();
            Console.WriteLine($"TriggerMessage operation received for {response.Operation}. Choose an action to continue:");
            Console.WriteLine("\tA - Accept message");
            Console.WriteLine("\tR - Reject message");
            Console.Write("\r\nSelect an action: ");

            cki = Console.ReadKey();

            response.Status = cki.KeyChar switch
            {
                'a' => TriggerMessageResponseStatus.Accepted,
                'r' => TriggerMessageResponseStatus.Rejected,
                _ => TriggerMessageResponseStatus.NotImplemented,
            };

            OcppOperation? operation = response.Operation;
            response.Operation = null;

            Console.WriteLine($"Sending TriggerMessage {response.Status}...");
            await SendAsync(response);

            if (response.Status == TriggerMessageResponseStatus.Accepted)
            {
                switch (operation)
                {
                    case OcppOperation.BootNotification:
                        await SendBootNotificationAsync();
                        break;
                    case OcppOperation.DiagnosticsStatusNotification:
                        await SendDiagnosticsStatusNotificationAsync();
                        break;
                    case OcppOperation.FirmwareStatusNotification:
                        await SendFirmwareStatusNotificationAsync();
                        break;
                    case OcppOperation.Heartbeat:
                        await SendHeartbeatAsync();
                        break;
                    case OcppOperation.MeterValues:
                        await SendMeterValuesAsync();
                        break;
                    case OcppOperation.StatusNotification:
                        await SendStatusNotificationAsync();
                        break;
                    default:
                        break;
                }
            }
        }

        private static JsonSerializerOptions GetSerializerOptions()
        {
            var options = new JsonSerializerOptions
            {
                IgnoreNullValues = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                PropertyNameCaseInsensitive = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            };
            options.Converters.Add(new JsonStringEnumConverter());
            return options;
        }

        private static async Task SendAsync<T>(T request)
            where T : class, IAction
        {
            if (_socket.State == WebSocketState.Open)
            {
                var message = OcppMessage.Compose(request);

                if (message.Action != OcppOperation.Unknown)
                    _operationQueue.Add((id: message.MessageId, action: message.Action));

                await _socket.SendAsync(Encoding.UTF8.GetBytes(message.ToString()), WebSocketMessageType.Text, true, CancellationToken.None);
                message.Log(false);
            }
        }
    }
}

