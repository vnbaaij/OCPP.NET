using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
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
using Spectre.Console;

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

        private static readonly ExceptionSettings _exceptionSettings = new()
        {
            Format = ExceptionFormats.ShortenEverything | ExceptionFormats.ShowLinks,
            Style = new ExceptionStyle
            {
                Exception = new Style().Foreground(Color.Grey),
                Message = new Style().Foreground(Color.White),
                NonEmphasized = new Style().Foreground(Color.Cornsilk1),
                Parenthesis = new Style().Foreground(Color.Cornsilk1),
                Method = new Style().Foreground(Color.Red),
                ParameterName = new Style().Foreground(Color.Cornsilk1),
                ParameterType = new Style().Foreground(Color.Red),
                Path = new Style().Foreground(Color.Red),
                LineNumber = new Style().Foreground(Color.Cornsilk1),
            }
        }; 

        private const bool logVerbose = true;


        public static WebSocketState State
        {
            get => _socket?.State ?? WebSocketState.None;
        }

        public static async Task Start(string wsUri) => await Start(new Uri(wsUri));

        public static async Task Start(Uri wsUri)
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
                AnsiConsole.WriteException(ex, _exceptionSettings);
            }
        }

        public static async Task Stop()
        {
            Console.WriteLine($"\nClosing connection");
            _sendTokenSource.Cancel();
            if (_socket == null || _socket.State != WebSocketState.Open) return;

            // close the _socket first, because ReceiveAsync leaves an invalid _socket (state = aborted) when the token is cancelled
            var timeout = new CancellationTokenSource(5000);

            try
            {
                // after this, the _socket state which change to CloseSent
                await _socket.CloseOutputAsync(WebSocketCloseStatus.NormalClosure, "Closing", timeout.Token);
                // now we wait for the server response, which will close the _socket
                while (_socket.State != WebSocketState.Closed && !timeout.Token.IsCancellationRequested) ;
            }
            catch (OperationCanceledException)
            {
                // normal upon task/token cancellation, disregard
            }
            // whether we closed the _socket or timed out, we cancel the token causing RecieveAsync to abort the _socket
            _receiveTokenSource.Cancel();
            // the finally block at the end of the processing loop will dispose and null the _socket object
        }


        public static void QueueOperation(string operation) => _keyQueue.Add(operation);


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
                            Console.WriteLine($"\nAcknowledging Close frame received from server");
                            _sendTokenSource.Cancel();
                            await _socket.CloseOutputAsync(WebSocketCloseStatus.NormalClosure, "Acknowledge Close frame", CancellationToken.None);
                        }

                        // display text or binary data
                        if (_socket.State == WebSocketState.Open && result.MessageType != WebSocketMessageType.Close)
                        {
                            OcppMessage responseMessage = new(buffer.Take(result.Count).ToArray());
                            if (_operationQueue.TryTake(out var operation))
                            {
                                if (operation.id == responseMessage.MessageId)
                                {
                                    responseMessage.Action = operation.action;
                                }
                            }

                            LogStatus(true, responseMessage);

                            switch (responseMessage.Action)
                            {
                                case OcppOperation.BootNotification:
                                    await ReceiveBootNotificationAsync(responseMessage);
                                    break;
                                case OcppOperation.Authorize:
                                    ReceiveAuthorizeAsync(responseMessage);
                                    break;
                                case OcppOperation.ClearCache:
                                    await ReceiveClearCacheAsync(responseMessage);
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
                AnsiConsole.WriteException(ex, _exceptionSettings);
            }
            finally
            {
                _sendTokenSource.Cancel();
                _socket.Dispose();
                _socket = null;
            }
        }

        private static async Task SendAsync()
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
                            case "7":
                                await DiagnosticsStatusNotification();
                                break;
                            case "8":
                                await DataTransfer();
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
                    AnsiConsole.WriteException(ex, _exceptionSettings);
                }
            }
        }

        public static async Task SendBootNotificationAsync()
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

            await Send(request);
        }

        public static async Task ReceiveBootNotificationAsync(OcppMessage responseMessage)
        {
            BootNotificationResponse response = ProcessResponse<BootNotificationResponse>(responseMessage);

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

       

        private static async Task SendAuthorizeAsync()
        {
            var request = new AuthorizeRequest
            {
                IdTag = "3060044040003000853"
            };

            await Send(request);
        }

        private static void ReceiveAuthorizeAsync(OcppMessage responseMessage)
        {
            AuthorizeResponse response = ProcessResponse<AuthorizeResponse>(responseMessage);

            Console.WriteLine($"Authorization status: {response.IdTagInfo.Status}.");
            Program._waitloopTokenSource.Cancel();
        }


        private static async Task DiagnosticsStatusNotification()
        {

            var request = new DiagnosticsStatusNotificationRequest
            {
                Status = DiagnosticsStatusNotificationRequestStatus.Idle

            };

            await Send(request);

            var response = await Receive<DiagnosticsStatusNotificationRequest, DiagnosticsStatusNotificationResponse>(request);
        }


        private static async Task DataTransfer()
        {
            var request = new DataTransferRequest
            {
                VendorId = "",
                Data = "Just some random extra data",
                MessageId = ""

            };

            await Send(request);

            var response = Receive<DataTransferRequest, DataTransferResponse>(request);
        }

        private static async Task SendClearCacheAsync(ClearCacheResponse response, bool accepted)
        {

            if (accepted)
                response.Status = ClearCacheResponseStatus.Accepted;
            else
                response.Status = ClearCacheResponseStatus.Rejected;

            await Send(response);


        }

        private static async Task ReceiveClearCacheAsync(OcppMessage responseMessage)
        {
            
            ClearCacheResponse response = ProcessResponse<ClearCacheResponse>(responseMessage);

            ConsoleKeyInfo cki;

            AnsiConsole.Reset();
            AnsiConsole.WriteLine("ClearCache operation received. ");
            AnsiConsole.WriteLine("\tPress 'a' to accept or any other key reject");
            AnsiConsole.Write("\r\nSelect an action: ");

            cki = Console.ReadKey();

            bool status = cki.KeyChar == 'a';
            await SendClearCacheAsync(response, status);
            Program._waitloopTokenSource.Cancel();
        }

        private static TResponse ProcessResponse<TResponse>(OcppMessage responseMessage)
           where TResponse : ResponseBase<TResponse>
        {
            JsonSerializerOptions options = GetSerializerOptions();

            TResponse response = JsonSerializer.Deserialize<TResponse>(responseMessage.Payload, options);
            response.MessageId = responseMessage.MessageId;
            return response;
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


        private static OcppMessage ComposeMessage<T>(T action)
            where T : class, IAction
        {
            JsonSerializerOptions options = GetSerializerOptions();

            var message = new OcppMessage();

            switch (action)
            {
                case IRequest request:
                    message.MessageType = MessageType.CALL;
                    message.MessageId = Guid.NewGuid();
                    _ = Enum.TryParse<OcppOperation>(request.GetType().Name.Replace("Request", ""), out OcppOperation operation);
                    message.Action = operation;
                    break;
                case IResponse response:
                    message.MessageType = MessageType.CALLRESULT;
                    message.MessageId = response.MessageId;
                    message.Action = OcppOperation.Unknown;
                    break;
                default:
                    break;
            }

            message.Payload = JsonSerializer.Serialize<object>(action, options);
            return message;
        }

        private static async Task Send<T>(T request)
            where T : class, IAction
        {
            if (_socket.State == WebSocketState.Open)
            {
                var message = ComposeMessage(request);

                if (message.Action != OcppOperation.Unknown)
                    _operationQueue.Add((id: message.MessageId, action: message.Action));

                await _socket.SendAsync(Encoding.UTF8.GetBytes(message.ToString()), WebSocketMessageType.Text, true, CancellationToken.None);
                LogStatus(false, message);
            }
        }


        private static async Task<TResponse> Receive<TResponse>()
            where TResponse : ResponseBase<TResponse>
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
                            Console.WriteLine($"\nAcknowledging Close frame received from server");
                            _sendTokenSource.Cancel();
                            await _socket.CloseOutputAsync(WebSocketCloseStatus.NormalClosure, "Acknowledge Close frame", CancellationToken.None);
                        }

                        // display text or binary data
                        if (_socket.State == WebSocketState.Open && result.MessageType != WebSocketMessageType.Close)
                        {
                            OcppMessage responseMessage = new(buffer.Take(result.Count).ToArray());
                            LogStatus(true, responseMessage);
                            string payload = responseMessage.Payload;
                            //string message = Encoding.UTF8.GetString(buffer.Array, 0, result.Count);
                            //if (message.Length > 1) message = "\n" + message + "\n";
                            //Console.Write(message);

                            JsonSerializerOptions options = GetSerializerOptions();

                            TResponse response = JsonSerializer.Deserialize<TResponse>(payload, options);
                            response.MessageId = responseMessage.MessageId;
                            return response;
                        }
                    }
                }
            }
            catch (OperationCanceledException)
            {
                // normal upon task/token cancellation, disregard
            }
            catch (Exception ex)
            {
                AnsiConsole.WriteException(ex, new ExceptionSettings
                {
                    Format = ExceptionFormats.ShortenEverything | ExceptionFormats.ShowLinks,
                    Style = new ExceptionStyle
                    {
                        Exception = new Style().Foreground(Color.Grey),
                        Message = new Style().Foreground(Color.White),
                        NonEmphasized = new Style().Foreground(Color.Cornsilk1),
                        Parenthesis = new Style().Foreground(Color.Cornsilk1),
                        Method = new Style().Foreground(Color.Red),
                        ParameterName = new Style().Foreground(Color.Cornsilk1),
                        ParameterType = new Style().Foreground(Color.Red),
                        Path = new Style().Foreground(Color.Red),
                        LineNumber = new Style().Foreground(Color.Cornsilk1),
                    }
                });
            }
            finally
            {
                //_sendTokenSource.Cancel();
                //_socket.Dispose();
                //_socket = null;
            }

            return default;

        }

        private static async Task<TResponse> Receive<TRequest, TResponse>(TRequest request = null)
            where TRequest : RequestBase<TRequest>
            where TResponse : ResponseBase<TRequest, TResponse>

        {
            TResponse response = await Receive<TResponse>();
            response.Request = request;
            return response;
        }

        private static void LogStatus(bool receiving, OcppMessage ocppMessage)
        {


            if (receiving)
                Console.ForegroundColor = ConsoleColor.Green;
            else
                Console.ForegroundColor = ConsoleColor.Gray;

            if (logVerbose)
            {
                Console.WriteLine("\n----------------------------------------------------------------------");
                Console.WriteLine($"MessageType: {ocppMessage.MessageType}, Id: {ocppMessage.MessageId}");
                if (ocppMessage.Action != OcppOperation.Unknown)
                    Console.WriteLine($"Action: {ocppMessage.Action}");

                LogPayload(ocppMessage.Payload);
            }

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine();

            Console.ResetColor();

        }

        private static void LogPayload(string payload)
        {
            var options = new JsonWriterOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                Indented = true
            };

            var json = JsonDocument.Parse(payload);

            Console.WriteLine("Payload:");
            using var writer = new Utf8JsonWriter(Console.OpenStandardOutput(), options: options);

            writer.WriteStartObject();
            foreach (JsonProperty property in json.RootElement.EnumerateObject())
            {
                property.WriteTo(writer);
            }
            writer.WriteEndObject();

            writer.Flush();

            Console.WriteLine();
        }
    }
}

