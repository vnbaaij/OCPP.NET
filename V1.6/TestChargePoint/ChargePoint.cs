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
using OCPP.V16.RemoteTrigger;

namespace TestChargePoint
{
    public static class ChargePoint
    {

        private const string id = "CS_28_1";
        private const string csmsUrl = "ws://localhost:8180/steve/websocket/CentralSystemService/";

        private static readonly object consoleLock = new();
        private static ClientWebSocket _socket;

        private static readonly BlockingCollection<OcppAction> _menuQueue = new();
        private static readonly BlockingCollection<(Guid id, OcppAction action, IRequest request)> _operationQueue = new();

        private static CancellationTokenSource _receiveTokenSource;
        private static CancellationTokenSource _sendTokenSource;
        private static CancellationTokenSource _menuTokenSource;

        //private static int _heartbeatInterval = 300;
        //private static DateTime _csmsDateTime;
        //private static int _transactionId;

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
            Console.WriteLine($"Closing connection");
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
                    cki = Console.ReadKey(false);
                    //Console.WriteLine();

                    switch (cki.KeyChar)
                    {
                        case '1':
                            _menuQueue.Add(OcppAction.BootNotification);
                            break;
                        case '2':
                            _menuQueue.Add(OcppAction.Authorize);
                            break;
                        case '3':
                            _menuQueue.Add(OcppAction.StartTransaction);
                            break;
                        case '4':
                            _menuQueue.Add(OcppAction.StopTransaction);
                            break;
                        case '5':
                            _menuQueue.Add(OcppAction.Heartbeat);
                            break;
                        case '6':
                            _menuQueue.Add(OcppAction.MeterValues);
                            break;
                        case '7':
                            _menuQueue.Add(OcppAction.DiagnosticsStatusNotification);
                            break;
                        case '8':
                            _menuQueue.Add(OcppAction.DataTransfer);
                            break;
                        case '9':
                            _menuQueue.Add(OcppAction.StatusNotification);
                            break;
                        case 'r':
                            break;
                    }

                    if (cki.Key == ConsoleKey.Escape)
                    {
                        running = false;
                        Console.WriteLine();
                        _menuTokenSource.Cancel();
                    }
                    await Task.Run(() => Task.Delay(20000, _menuTokenSource.Token));


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
                            case OcppAction.BootNotification:
                                await SendBootNotificationAsync();
                                break;
                            case OcppAction.Authorize:
                                await SendAuthorizeAsync();
                                break;
                            case OcppAction.Heartbeat:
                                await SendHeartbeatAsync();
                                break;
                            case OcppAction.DiagnosticsStatusNotification:
                                await SendDiagnosticsStatusNotificationAsync();
                                break;
                            case OcppAction.DataTransfer:
                                await SendDataTransferAsync();
                                break;
                            case OcppAction.StatusNotification:
                                await SendStatusNotificationAsync();
                                break;
                            case OcppAction.StartTransaction:
                                await SendStartTransactionAsync();
                                break;
                            case OcppAction.StopTransaction:
                                await SendStopTransactionAsync();
                                break;
                            case OcppAction.MeterValues:
                                await SendMeterValuesAsync();
                                break;
                            case OcppAction.ClearCache:
                                break;
                            case OcppAction.FirmwareStatusNotification:
                                break;
                            case OcppAction.TriggerMessage:
                                break;
                            case OcppAction.UpdateFirmware:
                                break;
                            case OcppAction.Unknown:
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

                            IAction action;

                            switch (message.Action)
                            {
                                case OcppAction.BootNotification:
                                    action = message.Parse<BootNotificationRequest, BootNotificationResponse>(operation.request as BootNotificationRequest);
                                    await HandleBootNotificationAsync(action as BootNotificationResponse);
                                    break;
                                case OcppAction.Authorize:
                                    action = message.Parse<AuthorizeRequest, AuthorizeResponse>(operation.request as AuthorizeRequest);
                                    HandleAuthorize(action as AuthorizeResponse);
                                    break;

                                case OcppAction.Heartbeat:
                                    action = message.Parse<HeartbeatResponse>();
                                    HandleHeartbeat(action as HeartbeatResponse);
                                    break;
                                case OcppAction.TriggerMessage:
                                    action = message.Parse<TriggerMessageRequest,TriggerMessageResponse>(operation.request as TriggerMessageRequest);
                                    await HandleTriggerMessageAsync(message);
                                    break;
                                case OcppAction.DataTransfer:
                                    action = message.Parse<DataTransferRequest, DataTransferResponse>(operation.request as DataTransferRequest);
                                    HandleDataTransfer(action as DataTransferResponse);
                                    break;
                                case OcppAction.StartTransaction:
                                    action = message.Parse<StartTransactionRequest, StartTransactionResponse>(operation.request as StartTransactionRequest);
                                    HandleStartTransaction(action as StartTransactionResponse);
                                    break;
                                case OcppAction.StopTransaction:
                                    action = message.Parse<StopTransactionRequest, StopTransactionResponse>(operation.request as StopTransactionRequest);
                                    HandleStopTransaction(action as StopTransactionResponse);
                                    break;

                                case OcppAction.ChangeAvailability:
                                    action = message.Parse<ChangeAvailabilityRequest>(false);
                                    await HandleChangeAvailability(action as ChangeAvailabilityRequest);
                                    break;
                                case OcppAction.ChangeConfiguration:
                                    action = message.Parse<ChangeConfigurationRequest, ChangeConfigurationResponse>(operation.request as ChangeConfigurationRequest);
                                    HandleChangeConfiguration(action as ChangeConfigurationResponse);
                                    break;
                                case OcppAction.ClearCache:
                                    action = message.Parse<ClearCacheResponse>();
                                    await HandleClearCacheAsync(message);
                                    break;

                                case OcppAction.GetConfiguration:
                                    action = message.Parse<GetConfigurationRequest>(false);
                                    HandleGetConfiguration(action as GetConfigurationRequest);
                                    break;
                                case OcppAction.UnlockConnector:
                                    action = message.Parse<UnlockConnectorRequest>(false);
                                    await HandleUnlockConnector(action as UnlockConnectorRequest);
                                    break;
                                case OcppAction.Reset:
                                    action = message.Parse<ResetRequest>(true);
                                    await HandleReset(action as ResetRequest);
                                    break;
                                case OcppAction.RemoteStartTransaction:
                                    action = message.Parse<RemoteStartTransactionRequest>(false);
                                    await HandleRemoteStartTransaction(action as RemoteStartTransactionRequest);
                                    break;
                                case OcppAction.RemoteStopTransaction:
                                    action = message.Parse<RemoteStopTransactionRequest>(false);
                                    await HandleRemoteStopTransaction(action as RemoteStopTransactionRequest);
                                    break;

                                case OcppAction.DiagnosticsStatusNotification:
                                case OcppAction.FirmwareStatusNotification:
                                case OcppAction.StatusNotification:
                                case OcppAction.MeterValues:
                                case OcppAction.UpdateFirmware:
                                    action = message.Parse<EmptyResponse>();
                                    _menuTokenSource.Cancel();
                                    break;
                                case OcppAction.Unknown:
                                    Console.WriteLine("Unknown or unhandeled action received");
                                    _menuTokenSource.Cancel();
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

        private static async Task SendAuthorizeAsync(string idTag = null)
        {

            if (idTag is null)
                idTag = Configuration.GetConfigurationValue<string>(Configuration.Settings, "IdTag");

            var request = new AuthorizeRequest(IdTag: idTag);

            await SendMessageAsync(request);
        }

        private static async Task SendBootNotificationAsync()
        {
            var request = new BootNotificationRequest(
                ChargePointVendor: "Baaijte",
                ChargePointModel: "QuickCharger 11+",
                ChargePointSerialNumber: "bqc.001.20.1",
                ChargeBoxSerialNumber: "bqc.001.20.1.01",
                FirmwareVersion: "3.11.20",
                MeterType: "Landis+Gyr E350",
                MeterSerialNumber: "4530303035303031363935303633303135"
            );

            await SendMessageAsync(request);
        }

        private static async Task SendClearCacheAsync(ClearCacheResponse response, bool accepted)
        {
            if (accepted)
                response = response with { Status = ClearCacheStatus.Accepted };
            else
                response = response with { Status = ClearCacheStatus.Rejected };

            await SendMessageAsync(response);
        }

        private static async Task SendDataTransferAsync()
        {
            var request = new DataTransferRequest(
                VendorId: "bbbbb",
                Data: "Just some random extra data",
                VendorMessageId: ""

            );

            await SendMessageAsync(request);
        }

        private static async Task SendDiagnosticsStatusNotificationAsync()
        {

            var request = new DiagnosticsStatusNotificationRequest(Status: DiagnosticsStatus.Idle);

            await SendMessageAsync(request);
        }

        private static async Task SendFirmwareStatusNotificationAsync()
        {
            var request = new FirmwareStatusNotificationRequest(Status: FirmwareStatus.Idle);

            await SendMessageAsync(request);
        }

        private static async Task SendHeartbeatAsync()
        {
            var request = new EmptyRequest();

            await SendMessageAsync(request);
        }

        private static async Task SendMeterValuesAsync()
        {
            List<MeterValue> meterValueList = new();

            List<SampledValue> sampledValueList = new();

            SampledValue sv = new(
                Context: ReadingContext.Sample_Periodic,
                Format: ValueFormat.Raw,
                Location: Location.Outlet,
                Measurand: Measurand.Voltage,
                Phase: Phase.N,
                Unit: UnitOfMeasure.V,
                Value: "230"
            );
            sampledValueList.Add(sv);


            MeterValue mv = new
            (
                SampledValue: sampledValueList,
                Timestamp: DateTime.UtcNow
            );
            meterValueList.Add(mv);

            int transactionId = Configuration.GetConfigurationValue<int>(Configuration.Settings, "TransactionId");
            var request = new MeterValuesRequest(
                ConnectorId: 0,
                TransactionId: transactionId != 0 ? transactionId : null,
                MeterValues: meterValueList
            );

            await SendMessageAsync(request);
        }

        private static async Task SendStatusNotificationAsync()
        {
            var request = new StatusNotificationRequest(
                ConnectorId: 1,
                ErrorCode: ChargePointErrorCode.NoError,
                Info: "Bla",
                Status: ChargePointStatus.Available,
                Timestamp: DateTime.UtcNow,
                VendorErrorCode: "My Vendor ErrorCode",
                VendorId: "My Vendor Id"
         );

            await SendMessageAsync(request);
        }

        private static async Task SendStartTransactionAsync()
        {
            var request = new StartTransactionRequest(
                ConnectorId: 1,
                IdTag: Configuration.GetConfigurationValue<string>(Configuration.Settings, "IdTag"),
                MeterStart: Configuration.GetConfigurationValue<int>(Configuration.Settings, "MeterStart"),
                Timestamp: DateTime.UtcNow
            );


            await SendMessageAsync(request);
        }

        private static async Task SendStopTransactionAsync(int? transactionId = null)
        {
            if (transactionId is null)
                transactionId = Configuration.GetConfigurationValue<int>(Configuration.Settings, "TransactionId"); ;

            var request = new StopTransactionRequest(
                IdTag: Configuration.GetConfigurationValue<string>(Configuration.Settings, "IdTag"),
                Timestamp: DateTime.UtcNow,
                MeterStop: Configuration.GetConfigurationValue<int>(Configuration.Settings, "MeterStop"),
                Reason: Reason.UnlockCommand,
                TransactionId: (int)transactionId
            );

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
                Configuration.SetConfigurationValue(Configuration.Settings, "HearbeatInterval", response.Interval);
                //_heartbeatInterval = response.Interval;

            Console.WriteLine($"BootNotification {response.Status}.");
            switch (response.Status)
            {
                case RegistrationStatus.Accepted:
                    Configuration.SetConfigurationValue(Configuration.Settings, "CsmsDateTime", response.CurrentTime);
                    //_csmsDateTime = response.CurrentTime;


                    Console.WriteLine($"- Heartbeat interval: {response.Interval / 60} min(s)");
                    Console.WriteLine($"- Central System date/time: {response.CurrentTime} (UTC)\n");
                    break;
                case RegistrationStatus.Rejected:
                    Console.WriteLine($"- Waiting {response.Interval} seconds before reattempt");
                    Thread.Sleep(response.Interval * 100);
                    await SendBootNotificationAsync();
                    break;
                case RegistrationStatus.Pending:

                    //await Receive<TriggerMessageRequest, TriggerMessageResponse>();
                    break;
            }
            _menuTokenSource.Cancel();
        }



        private static void HandleDataTransfer(DataTransferResponse response)
        {
            Console.WriteLine($"DataTransfer status: {response.Status}.");
            _menuTokenSource.Cancel();
        }

        private static void HandleHeartbeat(HeartbeatResponse response)
        {
            Configuration.SetConfigurationValue(Configuration.Settings, "CsmsDateTime", response.CurrentTime);
            //_csmsDateTime = response.CurrentTime;

            Console.WriteLine($"- Central System date/time: {response.CurrentTime} (UTC)\n");
            _menuTokenSource.Cancel();
        }

        private static async Task HandleTriggerMessageAsync(OcppMessage message)
        {
            TriggerMessageResponse response = message.Parse<TriggerMessageResponse>();

            ConsoleKeyInfo cki;

            Console.ResetColor();
            Console.WriteLine($"TriggerMessage operation received for {response.Operation}. Choose an action to continue:");
            Console.WriteLine("\ta - Accept message");
            Console.WriteLine("\tr - Reject message");
            Console.Write("\r\nSelect an action: ");

            cki = Console.ReadKey();

            response = response with
            {
                Status = cki.KeyChar switch
                {
                    'a' => TriggerMessageStatus.Accepted,
                    'r' => TriggerMessageStatus.Rejected,
                    _ => TriggerMessageStatus.NotImplemented,
                }
            };


            OcppAction? operation = response.Operation;
            response.Operation = null;

            Console.WriteLine($"Sending TriggerMessage {response.Status}...");
            await SendMessageAsync(response);

            if (response.Status == TriggerMessageStatus.Accepted)
            {
                switch (operation)
                {
                    case OcppAction.BootNotification:
                        await SendBootNotificationAsync();
                        break;
                    case OcppAction.DiagnosticsStatusNotification:
                        await SendDiagnosticsStatusNotificationAsync();
                        break;
                    case OcppAction.FirmwareStatusNotification:
                        await SendFirmwareStatusNotificationAsync();
                        break;
                    case OcppAction.Heartbeat:
                        await SendHeartbeatAsync();
                        break;
                    case OcppAction.MeterValues:
                        await SendMeterValuesAsync();
                        break;
                    case OcppAction.StatusNotification:
                        await SendStatusNotificationAsync();
                        break;
                    default:
                        break;
                }
            }
        }

        private static void HandleStartTransaction(StartTransactionResponse response)
        {
            Configuration.SetConfigurationValue(Configuration.Settings, "TransactionId", response.TransactionId);
            //_transactionId = ;

            Console.WriteLine($"- Transaction Id: {response.TransactionId}\n");
            _menuTokenSource.Cancel();
        }

        private static void HandleStopTransaction(StopTransactionResponse response)
        {
            Console.WriteLine($"- Transaction Id: {response.IdTagInfo.Status}\n");

            Configuration.SetConfigurationValue(Configuration.Settings, "TransactionId", 0);
            //_transactionId = 0;

            _menuTokenSource.Cancel();
        }


        private static void HandleGetConfiguration(GetConfigurationRequest request)
        {
            Console.WriteLine($"{request}");
        }

        private static async Task HandleChangeAvailability(ChangeAvailabilityRequest request)
        {
            ConsoleKeyInfo cki;

            Console.ResetColor();
            Console.WriteLine("ChangeAvailability request operation received. Choose how to respond:");
            Console.WriteLine("\t1 - Unlock message");
            Console.WriteLine("\t2 - Unlock failed message");
            Console.WriteLine("\t3 - Not Supported message");
            Console.Write("\r\nSelect an action: ");

            cki = Console.ReadKey();

            var response = new ChangeAvailabilityResponse(request, Status: cki.KeyChar switch
            {
                '1' => AvailabilityStatus.Accepted,
                '2' => AvailabilityStatus.Scheduled,
                _ => AvailabilityStatus.Rejected
            });


            Console.WriteLine($"\nSending UnlockConnectorResponse with status '{response.Status}'...");

            await SendMessageAsync(response);

            _menuTokenSource.Cancel();
        }

        private static void HandleChangeConfiguration(ChangeConfigurationResponse response)
        {
            throw new NotImplementedException();
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

            await SendClearCacheAsync(response, cki.KeyChar == 'a');
            _menuTokenSource.Cancel();
        }

        private static async Task HandleRemoteStartTransaction(RemoteStartTransactionRequest request)
        {
            bool authorizeRemoteTxRequests = Configuration.GetConfigurationValue<bool>(Configuration.Core, "AuthorizeRemoteTxRequests");

            if (request.ConnectorId is null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No connector id supplied. Remote start rejected!");
                Console.ResetColor();
                return;
            }

            if (authorizeRemoteTxRequests)
            {
                //1) Local AuthorizationList
                //2) Authorization Cache
                //3) Authorize
                await SendAuthorizeAsync(request.IdTag);

            }

            await SendStartTransactionAsync();

            _menuTokenSource.Cancel();
        }

        private static async Task HandleRemoteStopTransaction(RemoteStopTransactionRequest request)
        {
            ConsoleKeyInfo cki;

            Console.ResetColor();
            Console.WriteLine("RemoteStopTransaction request operation received. Choose how to respond:");
            Console.WriteLine("\ta - Accept");
            Console.WriteLine("\tr - Reject");
            Console.Write("\r\nSelect an action: ");

            cki = Console.ReadKey();

            var response = new RemoteStopTransactionResponse(request, Status: cki.KeyChar switch
            {
                'a' => RemoteStartStopStatus.Accepted,
                _ => RemoteStartStopStatus.Rejected
            });

            await SendMessageAsync(response);

            await SendStopTransactionAsync();

            _menuTokenSource.Cancel();
        }

        private static async Task HandleReset(ResetRequest request)
        {
            ConsoleKeyInfo cki;

            Console.ResetColor();
            Console.WriteLine("Reset request operation received. ");
            Console.WriteLine("\tPress 'a' to accept or any other key reject");
            Console.Write("\r\nSelect an action: ");

            cki = Console.ReadKey();

            var response = new ResetResponse(request, Status: cki.KeyChar switch
            {
                'a' => ResetStatus.Accepted,
                _ => ResetStatus.Rejected
            });

            Console.WriteLine($"\nSending ResetResponse with status '{response.Status}'...");

            await SendMessageAsync(response);

            _menuTokenSource.Cancel();
        }

        private static async Task HandleUnlockConnector(UnlockConnectorRequest request)
        {
            Console.WriteLine($"- Status: {request}\n");

            ConsoleKeyInfo cki;

            Console.ResetColor();
            Console.WriteLine("UnlockConnector request operation received. Choose how to respond:");
            Console.WriteLine("\t1 - Unlock message");
            Console.WriteLine("\t2 - Unlock failed message");
            Console.WriteLine("\t3 - Not Supported message");
            Console.Write("\r\nSelect an action: ");

            cki = Console.ReadKey();

            var response = new UnlockConnectorResponse(request, Status: cki.KeyChar switch
            {
                '1' => UnlockStatus.Unlocked,
                '2' => UnlockStatus.UnlockFailed,
                _ => UnlockStatus.NotSupported
            });

            Console.WriteLine($"\nSending UnlockConnectorResponse with status '{response.Status}'...");

            await SendMessageAsync(response);

            _menuTokenSource.Cancel();
        }


        private static async Task SendMessageAsync<T>(T request)
            where T : class, IAction
        {
            if (_socket.State == WebSocketState.Open)
            {
                var message = OcppMessage.Compose(request);

                if (message.Action != OcppAction.Unknown)
                    _operationQueue.Add((id: message.MessageId, action: message.Action, request as IRequest));

                await _socket.SendAsync(Encoding.UTF8.GetBytes(message.ToString()), WebSocketMessageType.Text, true, CancellationToken.None);
                message.Log(false);
            }
        }
    }
}

