﻿using System;
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

        private const string id = "CS_28_1";
        private const string csmsUrl = "ws://localhost:8180/steve/websocket/CentralSystemService/";

        private static readonly object consoleLock = new();
        private static ClientWebSocket _socket;

        private static readonly BlockingCollection<OcppOperation> _menuQueue = new();
        private static readonly BlockingCollection<(Guid id, OcppOperation action)> _operationQueue = new();

        private static CancellationTokenSource _receiveTokenSource;
        private static CancellationTokenSource _sendTokenSource;
        private static CancellationTokenSource _menuTokenSource;

        private static int _heartbeatInterval = 300;
        private static DateTime _csmsDateTime;

        private static int? _transactionId = null;

        public static WebSocketState State
        {
            get => _socket?.State ?? WebSocketState.None;
        }

        public static async Task Run()
        {
            await StartAsync(csmsUrl + id);
            await HandleMenu();
            await StopAsync();
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

                _ = Task.Run(() => SendAsync().ConfigureAwait(false));
                _ = Task.Run(() => ReceiveAsync().ConfigureAwait(false));
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

        public static async Task HandleMenu()
        {
            ConsoleKeyInfo cki;
            bool running = true;

            do
            {
                try
                {
                    _menuTokenSource = new();
                    ShowMainMenu();
                    cki = Console.ReadKey();
                    Console.WriteLine();

                    switch (cki.KeyChar)
                    {
                        case '1':
                            _menuQueue.Add(OcppOperation.BootNotification);
                            break;
                        case '2':
                            _menuQueue.Add(OcppOperation.Authorize);
                            break;
                        case '3':
                            _menuQueue.Add(OcppOperation.StartTransaction);
                            break;
                        case '4':
                            _menuQueue.Add(OcppOperation.StopTransaction);
                            break;
                        case '5':
                            _menuQueue.Add(OcppOperation.Heartbeat);
                            break;
                        case '6':
                            _menuQueue.Add(OcppOperation.MeterValues);
                            break;
                        case '7':
                            _menuQueue.Add(OcppOperation.DiagnosticsStatusNotification);
                            break;
                        case '8':
                            _menuQueue.Add(OcppOperation.DataTransfer);
                            break;
                        case '9':
                            _menuQueue.Add(OcppOperation.StatusNotification);
                            break;
                        case 'r':
                            break;
                    }

                    if (cki.Key == ConsoleKey.Escape)
                    {
                        running = false;
                        _menuTokenSource.Cancel();
                    }
                    await Task.Run(() => Task.Delay(10000, _menuTokenSource.Token));
                }
                catch (OperationCanceledException)
                {

                }
            } while (running && State == WebSocketState.Open);
        }

        private static void ShowMainMenu()
        {
            //Console.Clear();
            lock (consoleLock)
            {
                Console.ResetColor();
                Console.WriteLine("\nChoose an action for this Charge Point:");
                Console.WriteLine("\t1 - Boot");
                Console.WriteLine("\t2 - Authorize");
                Console.WriteLine("\t3 - Start Transaction");
                Console.WriteLine("\t4 - Stop Transaction");
                Console.WriteLine("\t5 - Heartbeat");
                Console.WriteLine("\t6 - Send Meter Values");
                Console.WriteLine("\t7 - Diagnostics Status Notification");
                Console.WriteLine("\t8 - Data Transfer");
                Console.WriteLine("\t9 - Status Notification");
                Console.WriteLine("\tr - Check if message received from Central System (waits 10 seconds)");
                Console.WriteLine("\tESC - Exit");
                Console.Write("\r\nSelect an action: ");
            }
        }

        //public static void QueueOperation(OcppOperation operation) => _menuQueue.Add(operation);

        private static async Task SendAsync()
        {
            var cancellationToken = _sendTokenSource.Token;
            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    if (_menuQueue.TryTake(out var operation))
                    {

                        switch (operation)
                        {
                            case OcppOperation.BootNotification:
                                await SendBootNotificationAsync();
                                break;
                            case OcppOperation.Authorize:
                                await SendAuthorizeAsync();
                                break;
                            case OcppOperation.Heartbeat:
                                await SendHeartbeatAsync();
                                break;
                            case OcppOperation.DiagnosticsStatusNotification:
                                await SendDiagnosticsStatusNotificationAsync();
                                break;
                            case OcppOperation.DataTransfer:
                                await SendDataTransferAsync();
                                break;
                            case OcppOperation.StatusNotification:
                                await SendStatusNotificationAsync();
                                break;
                            case OcppOperation.StartTransaction:
                                await SendStartTransactionAsync();
                                break;
                            case OcppOperation.StopTransaction:
                                await SendStopTransactionAsync();
                                break;
                            case OcppOperation.MeterValues:
                                await SendMeterValuesAsync();
                                break;
                            case OcppOperation.ClearCache:
                                break;
                            case OcppOperation.FirmwareStatusNotification:
                                break;
                            case OcppOperation.TriggerMessage:
                                break;
                            case OcppOperation.UpdateFirmware:
                                break;
                            case OcppOperation.Unknown:
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

        
        private static async Task ReceiveAsync()
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
                                    _menuTokenSource.Cancel();
                                    break;
                                case OcppOperation.Unknown:
                                    break;
                                case OcppOperation.StartTransaction:
                                    response = message.Parse<StartTransactionResponse>();
                                    HandleStartTransaction(response as StartTransactionResponse);
                                    break;
                                case OcppOperation.StopTransaction:
                                    response = message.Parse<StopTransactionResponse>();
                                    HandleStopTransaction(response as StopTransactionResponse);
                                    break;
                            }
                        }
                    }
                }
                Console.WriteLine($"Stop receiving messages from Central System (socket state: {_socket.State})");
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

            await SendMessageAsync(request);
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

            await SendMessageAsync(request);
        }

        private static async Task SendClearCacheAsync(ClearCacheResponse response, bool accepted)
        {
            if (accepted)
                response.Status = ClearCacheResponseStatus.Accepted;
            else
                response.Status = ClearCacheResponseStatus.Rejected;

            await SendMessageAsync(response);
        }

        private static async Task SendDataTransferAsync()
        {
            var request = new DataTransferRequest
            {
                VendorId = "",
                Data = "Just some random extra data",
                MessageId = ""

            };

            await SendMessageAsync(request);
        }

        private static async Task SendDiagnosticsStatusNotificationAsync()
        {

            var request = new DiagnosticsStatusNotificationRequest
            {
                Status = DiagnosticsStatusNotificationRequestStatus.Idle

            };

            await SendMessageAsync(request);
        }

        private static async Task SendFirmwareStatusNotificationAsync()
        {
            var request = new FirmwareStatusNotificationRequest
            {
                Status = FirmwareStatusNotificationRequestStatus.Idle

            };

            await SendMessageAsync(request);
        }

        private static async Task SendHeartbeatAsync()
        {
            var request = new HeartbeatRequest();

            await SendMessageAsync(request);
        }

        private static Task SendMeterValuesAsync()
        {
            var request = new MeterValuesRequest
            {
                ConnectorId = 0,
                TransactionId = _transactionId ?? null,
                MeterValue = new MeterValue
                {
                    SampledValue = new SampledValue
                    {
                        Context = ReadingContext.
                    },
                    Timestamp = DateTime.UtcNow,
                }

            };
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

            await SendMessageAsync(request);
        }

        private static async Task SendStopTransactionAsync()
        {
            var request = new StopTransactionRequest
            {
                IdTag = "3060044040003000853",
                Timestamp = DateTime.UtcNow,
                MeterStop = 123457,
                Reason = StopTransactionRequestReason.UnlockCommand,
                TransactionId = _transactionId
            };


            await SendMessageAsync(request);

        }

        private static async Task SendStartTransactionAsync()
        {
            var request = new StartTransactionRequest
            {
                ConnectorId = 1,
                IdTag = "3060044040003000853",
                MeterStart = 123456,
                Timestamp = DateTime.UtcNow
            };


            await SendMessageAsync(request);
        }


        private static void HandleAuthorize(AuthorizeResponse response)
        {
            Console.WriteLine($"Authorization status: {response.IdTagInfo.Status}.");
            _menuTokenSource.Cancel();
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
            _menuTokenSource.Cancel();
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
            _menuTokenSource.Cancel();
        }

        private static void HandleDataTransfer(DataTransferResponse response)
        {
            Console.WriteLine($"DataTransfer status: {response.Status}.");
            _menuTokenSource.Cancel();
        }

        private static void HandleHeartbeat(HeartbeatResponse response)
        {
            _csmsDateTime = response.CurrentTime;

            Console.WriteLine($"- Central System date/time: {_csmsDateTime} (UTC)\n");
            _menuTokenSource.Cancel();
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
            await SendMessageAsync(response);

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

        private static void HandleStartTransaction(StartTransactionResponse response)
        {
            _transactionId = response.TransactionId;

            Console.WriteLine($"- Transaction Id: {_transactionId}\n");
            _menuTokenSource.Cancel();
        }

        private static void HandleStopTransaction(StopTransactionResponse response)
        {
            
            Console.WriteLine($"- Transaction Id: {response.IdTagInfo.Status}\n");

            _transactionId = null;

            _menuTokenSource.Cancel();
        }

        private static async Task SendMessageAsync<T>(T request)
            where T : class, IOperation
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

