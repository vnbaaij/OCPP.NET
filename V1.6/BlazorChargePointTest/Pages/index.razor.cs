using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using OCPP.V16;
using OCPP.V16.Core;
using OCPP.V16.FirmwareManagement;
using OCPP.V16.RemoteTrigger;

namespace BlazorChargePointTest.Pages
{
    public partial class Index
    {

        private const string id = "CS_28_1";
        private const string csmsUrl = "ws://localhost:8180/steve/websocket/CentralSystemService/";

        private static readonly Stack<(Guid id, OcppAction action, IRequest request)> _operationStack = new();

        private static readonly CancellationTokenSource _sendTokenSource = new();
        private static readonly CancellationTokenSource _receiveTokenSource = new();
        private static ClientWebSocket _socket = new();


        protected List<string> Log = new();

        [Inject] Configuration Configuration { get; set; }

        protected override async Task OnInitializedAsync()
        {
            string wsUri = csmsUrl + id;

            try
            {
                Log.Add($"Connecting to Central System ({wsUri})...");

                _socket.Options.AddSubProtocol("ocpp1.6");

                await _socket.ConnectAsync(new Uri(wsUri), _sendTokenSource.Token);

                Log.Add(" - connected!");
                _ = ReceiveAsync();

            }
            catch (Exception ex)
            {
                Log.Add($"Exception: {ex}");

            }
        }
        private async Task SendAuthorizeAsync(string idTag = null)
        {

            if (idTag is null)
                idTag = Configuration.GetConfigurationValue<string>(Configuration.Settings, "IdTag");

            AuthorizeRequest request = new(IdTag: idTag);

            await SendMessageAsync(request);
        }

        private async Task SendBootNotificationAsync()
        {
            BootNotificationRequest request = new(
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


        private async Task SendClearCacheAsync(ClearCacheResponse response, bool accepted)
        {
            if (accepted)
                response = response with { Status = ClearCacheStatus.Accepted };
            else
                response = response with { Status = ClearCacheStatus.Rejected };

            await SendMessageAsync(response, "ClearCache");
        }

        private async Task SendDataTransferAsync()
        {
            DataTransferRequest request = new(
                VendorId: "net.baaijte",
                Data: "Just some random extra data"

            );
            request.VendorMessageId = "2A";

            await SendMessageAsync(request);
        }

        private async Task SendDiagnosticsStatusNotificationAsync()
        {

            DiagnosticsStatusNotificationRequest request = new(Status: DiagnosticsStatus.Idle);

            await SendMessageAsync(request);
        }

        private async Task SendFirmwareStatusNotificationAsync()
        {
            FirmwareStatusNotificationRequest request = new(Status: FirmwareStatus.Idle);

            await SendMessageAsync(request);
        }

        private async Task SendHeartbeatAsync()
        {
            HeartbeatRequest request = new();

            await SendMessageAsync(request);
        }

        private async Task SendMeterValuesAsync()
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
            MeterValuesRequest request = new(ConnectorId: 0, TransactionId: transactionId != 0 ? transactionId : null, MeterValues: meterValueList);

            await SendMessageAsync(request);
        }

        private async Task SendStatusNotificationAsync()
        {
            StatusNotificationRequest request = new(ConnectorId: 1, ErrorCode: ChargePointErrorCode.NoError, Info: "Bla", Status: ChargePointStatus.Available, Timestamp: DateTime.UtcNow, VendorErrorCode: "My Vendor ErrorCode", VendorId: "My Vendor Id");

            await SendMessageAsync(request);
        }

        private async Task SendStartTransactionAsync()
        {
            StartTransactionRequest request = new(ConnectorId: 1, IdTag: Configuration.GetConfigurationValue<string>(Configuration.Settings, "IdTag"), MeterStart: Configuration.GetConfigurationValue<int>(Configuration.Settings, "MeterStart"), Timestamp: DateTime.UtcNow);


            await SendMessageAsync(request);
        }

        private async Task SendStopTransactionAsync(int? transactionId = null)
        {
            if (transactionId is null)
                transactionId = Configuration.GetConfigurationValue<int>(Configuration.Settings, "TransactionId"); ;

            StopTransactionRequest request = new(IdTag: Configuration.GetConfigurationValue<string>(Configuration.Settings, "IdTag"), Timestamp: DateTime.UtcNow, MeterStop: Configuration.GetConfigurationValue<int>(Configuration.Settings, "MeterStop"), Reason: Reason.UnlockCommand, TransactionId: (int)transactionId);

            await SendMessageAsync(request);
        }

        private async Task SendTriggerMessageAsync(TriggerMessageResponse response, bool accepted)
        {
            if (accepted)
                response = response with { Status = TriggerMessageStatus.Accepted };
            else
                response = response with { Status = TriggerMessageStatus.Rejected };

            response.Operation = null;

            await SendMessageAsync(response, "TriggerMessage");
        }


        private async Task SendMessageAsync<T>(T action, string responseAction = null)
            where T : class, IAction
        {
            if (_socket?.State == WebSocketState.Open)
            {
                var message = OcppMessage.Compose(action);

                if (message.Action != OcppAction.Unknown)
                    _operationStack.Push((id: message.MessageId, action: message.Action, action as IRequest));

                await _socket.SendAsync(Encoding.UTF8.GetBytes(message.ToString()), WebSocketMessageType.Text, true, CancellationToken.None);
                Log.Add(message.Log(false, responseAction));

            }
        }

        private async Task ReceiveAsync()
        {
            CancellationToken cancellationToken = _receiveTokenSource.Token;
            try
            {
                ArraySegment<byte> buffer = WebSocket.CreateClientBuffer(4096, 4096);
                while (_socket.State != WebSocketState.Closed && !cancellationToken.IsCancellationRequested)
                {
                    WebSocketReceiveResult result = await _socket.ReceiveAsync(buffer, cancellationToken);
                    // if the token is cancelled while ReceiveAsync is blocking, the _socket state changes to aborted and it can't be used
                    if (!cancellationToken.IsCancellationRequested)
                    {
                        // the server is notifying us that the connection will close; send acknowledgement
                        if (_socket.State == WebSocketState.CloseReceived && result.MessageType == WebSocketMessageType.Close)
                        {
                            Log.Add($"Acknowledging connection will close notification from server");
                            _sendTokenSource.Cancel();
                            await _socket.CloseOutputAsync(WebSocketCloseStatus.NormalClosure, "Acknowledge closing connection", CancellationToken.None);
                        }

                        if (_socket.State == WebSocketState.Open && result.MessageType != WebSocketMessageType.Close)
                        {
                            OcppMessage message = new(buffer.Take(result.Count).ToArray());
                            if (_operationStack.TryPop(out (Guid id, OcppAction action, IRequest request) operation))
                            {
                                if (operation.id == message.MessageId)
                                {
                                    message.Action = operation.action;
                                }
                            }

                            Log.Add(message.Log(true));
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
                                    //action = message.Parse<TriggerMessageRequest, TriggerMessageResponse>(operation.request as TriggerMessageRequest);
                                    HandleTriggerMessage(message);
                                    break;
                                case OcppAction.DataTransfer:
                                    if (message.MessageType == MessageType.CALLRESULT)
                                    {
                                    action = message.Parse<DataTransferRequest, DataTransferResponse>(operation.request as DataTransferRequest);
                                    HandleDataTransfer(action as DataTransferResponse);
                                    }
                                    else
                                        HandleDataTransferRequest(message);
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
                                    HandleClearCache(message);
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
                                    HandleReset(message);
                                    break;
                                case OcppAction.RemoteStartTransaction:
                                    action = message.Parse<RemoteStartTransactionRequest>(false);
                                    await HandleRemoteStartTransaction(action as RemoteStartTransactionRequest);
                                    break;
                                case OcppAction.RemoteStopTransaction:
                                    HandleRemoteStopTransaction(message);
                                    break;

                                case OcppAction.DiagnosticsStatusNotification:
                                case OcppAction.FirmwareStatusNotification:
                                case OcppAction.StatusNotification:
                                case OcppAction.MeterValues:
                                case OcppAction.UpdateFirmware:
                                    action = message.Parse<EmptyResponse>();

                                    break;
                                case OcppAction.Unknown:
                                    Log.Add("Unknown or unhandeled action received");
                                    break;
                            }
                            StateHasChanged();
                        }
                    }
                }
                Log.Add($"Stop receiving messages from Central System (socket state: {_socket.State})");
            }
            catch (OperationCanceledException)
            {
                // normal upon task/token cancellation, disregard
            }
            catch (Exception ex)
            {
                Log.Add($"Exception: {ex}");
            }
            finally
            {
                _sendTokenSource.Cancel();
                _socket.Dispose();
                _socket = null;
            }
        }

        private void HandleAuthorize(AuthorizeResponse response)
        {
            Log.Add($"Authorization status: {response.IdTagInfo.Status}.");
        }

        private async Task HandleBootNotificationAsync(BootNotificationResponse response)
        {
            if (response.Interval != 0)
                Configuration.SetSettingsValue("HeartbeatInterval", response.Interval);

            Log.Add($"BootNotification {response.Status}.");
            switch (response.Status)
            {
                case RegistrationStatus.Accepted:
                    Configuration.SetSettingsValue("CsmsDateTime", response.CurrentTime);
                    Log.Add($"- Heartbeat interval: {response.Interval / 60} min(s)");
                    Log.Add($"- Central System date/time: {response.CurrentTime} (UTC)");
                    break;
                case RegistrationStatus.Rejected:
                    Log.Add($"- Waiting {response.Interval} seconds before reattempt");
                    Thread.Sleep(response.Interval * 100);
                    await SendBootNotificationAsync();
                    break;
                case RegistrationStatus.Pending:

                    //await Receive<TriggerMessageRequest, TriggerMessageResponse>();
                    break;
            }

        }

        private async Task HandleChangeAvailabilityAsync(ChangeAvailabilityRequest request)
        {
            //ConsoleKeyInfo cki;

            //Log.Add("ChangeAvailability request operation received. Choose how to respond:");
            //Log.Add("\t1 - Unlock message");
            //Log.Add("\t2 - Unlock failed message");
            //Log.Add("\t3 - Not Supported message");
            //Console.Write("\r\nSelect an action: ");


            //var response = new ChangeAvailabilityResponse(request, Status: cki.KeyChar switch
            //{
            //    '1' => AvailabilityStatus.Accepted,
            //    '2' => AvailabilityStatus.Scheduled,
            //    _ => AvailabilityStatus.Rejected
            //});

            ChangeAvailabilityResponse response = new(request, Status: AvailabilityStatus.Accepted);

            Log.Add($"Sending UnlockConnectorResponse with status '{response.Status}'...");

            await SendMessageAsync(response);


        }

        private void HandleDataTransferRequest(OcppMessage message)
        {
            DataTransferRequest request = message.Parse<DataTransferRequest>(true);

            Configuration.Action = request;
            Configuration.OcppMessage = message;
            Configuration.UserMessage = $"A '{message.Action}' operation has been received.";
            Configuration.ShowingChoiceDialog = true;

            //DataTransferResponse response = new(request, Status: AvailabilityStatus.Accepted);
            //Log.Add($"Sending DataTransferResponse with status '{response.Status}'...");

            //await SendMessageAsync(response);
        }
        private void HandleDataTransfer(DataTransferResponse response)
        {
            Log.Add($"DataTransfer status: {response.Status}.");

        }

        private void HandleHeartbeat(HeartbeatResponse response)
        {
            Configuration.SetConfigurationValue(Configuration.Settings, "CsmsDateTime", response.CurrentTime);
            //_csmsDateTime = response.CurrentTime;

            Log.Add($"- Central System date/time: {response.CurrentTime} (UTC)");

        }

        private void HandleTriggerMessage(OcppMessage message)
        {
            TriggerMessageResponse response = message.Parse<TriggerMessageResponse>();

            Configuration.Action = response;
            Configuration.OcppMessage = message;
            Configuration.UserMessage = $"A '{message.Action}' operation has been received for '{response.Operation}'.";

            Configuration.ShowingChoiceDialog = true;
        }

        private void HandleStartTransaction(StartTransactionResponse response)
        {
            Configuration.SetConfigurationValue(Configuration.Settings, "TransactionId", response.TransactionId);
            //_transactionId = ;

            Log.Add($"- Transaction Id: {response.TransactionId}");

        }

        private void HandleStopTransaction(StopTransactionResponse response)
        {
            Log.Add($"- Transaction Id: {response.IdTagInfo.Status}");

            Configuration.SetConfigurationValue(Configuration.Settings, "TransactionId", 0);
            //_transactionId = 0;
        }

        private void HandleGetConfiguration(GetConfigurationRequest request)
        {
            Log.Add($"{request}");
        }

        private async Task HandleChangeAvailability(ChangeAvailabilityRequest request)
        {
            //ConsoleKeyInfo cki;

            //Log.Add("ChangeAvailability request operation received. Choose how to respond:");
            //Log.Add("\t1 - Unlock message");
            //Log.Add("\t2 - Unlock failed message");
            //Log.Add("\t3 - Not Supported message");
            //Console.Write("\r\nSelect an action: ");


            //var response = new ChangeAvailabilityResponse(request, Status: cki.KeyChar switch
            //{
            //    '1' => AvailabilityStatus.Accepted,
            //    '2' => AvailabilityStatus.Scheduled,
            //    _ => AvailabilityStatus.Rejected
            //});

            ChangeAvailabilityResponse response = new(request, Status: AvailabilityStatus.Accepted);

            Log.Add($"Sending UnlockConnectorResponse with status '{response.Status}'...");

            await SendMessageAsync(response);


        }

        private void HandleChangeConfiguration(ChangeConfigurationResponse response)
        {
            throw new NotImplementedException();
        }

        private void HandleClearCache(OcppMessage message)
        {
            ClearCacheResponse response = message.Parse<ClearCacheResponse>();

            Configuration.Action = response;
            Configuration.OcppMessage = message;
            Configuration.UserMessage = $"A '{message.Action}' operation has been received.";
            Configuration.ShowingChoiceDialog = true;
        }

        private async Task HandleRemoteStartTransaction(RemoteStartTransactionRequest request)
        {
            bool authorizeRemoteTxRequests = Configuration.GetConfigurationValue<bool>(Configuration.Core, "AuthorizeRemoteTxRequests");

            if (request.ConnectorId is null)
            {

                Log.Add("No connector id supplied. Remote start rejected!");

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


        }

        private void HandleRemoteStopTransaction(OcppMessage message)
        {
            RemoteStopTransactionRequest request = message.Parse<RemoteStopTransactionRequest>(true);
            RemoteStopTransactionResponse response = new(request, Status: RemoteStartStopStatus.Accepted);
            Configuration.Action = response;
            Configuration.OcppMessage = message;
            Configuration.UserMessage = $"A '{message.Action}' operation has been received.";
            Configuration.ShowingChoiceDialog = true;
        }

        private void HandleReset(OcppMessage message)
        {
            ResetRequest request = message.Parse<ResetRequest>(true);

            Configuration.Action = request;
            Configuration.OcppMessage = message;
            Configuration.UserMessage = $"A '{message.Action}' operation has been received.";
            Configuration.ShowingChoiceDialog = true;
        }

        private async Task HandleUnlockConnector(UnlockConnectorRequest request)
        {
            Log.Add($"- Status: {request}");

            //ConsoleKeyInfo cki;

            //Log.Add("UnlockConnector request operation received. Choose how to respond:");
            //Log.Add("\t1 - Unlock message");
            //Log.Add("\t2 - Unlock failed message");
            //Log.Add("\t3 - Not Supported message");
            //Console.Write("\r\nSelect an action: ");

            //var response = new UnlockConnectorResponse(request, Status: cki.KeyChar switch
            //{
            //    '1' => UnlockStatus.Unlocked,
            //    '2' => UnlockStatus.UnlockFailed,
            //    _ => UnlockStatus.NotSupported
            //});
            UnlockConnectorResponse response = new(request, Status: UnlockStatus.Unlocked);
            Log.Add($"Sending UnlockConnectorResponse with status '{response.Status}'...");

            await SendMessageAsync(response);
        }

        public async Task RejectMesssage()
        {
            IAction action;
            switch (Configuration.OcppMessage.Action)
            {
                case OcppAction.TriggerMessage:
                    action = Configuration.Action as TriggerMessageResponse;
                    Log.Add($"Sending 'TriggerMessage' {TriggerMessageStatus.Rejected}...");
                    await SendTriggerMessageAsync(action as TriggerMessageResponse, false);

                    break;
                case OcppAction.ClearCache:
                    action = Configuration.Action as ClearCacheResponse;
                    Log.Add($"Sending 'ClearCache' {ClearCacheStatus.Rejected}...");
                    await SendClearCacheAsync(action as ClearCacheResponse, false);
                    break;
                case OcppAction.DataTransfer:
                    DataTransferResponse dataTransferResponse = new(Configuration.Action as DataTransferRequest, Status: DataTransferStatus.Rejected);
                    Log.Add($"Sending 'DataTransferResponse' with status '{DataTransferStatus.Rejected}'...");
                    await SendMessageAsync(dataTransferResponse, "DataTransfer");
                    break;

                case OcppAction.Reset:
                    ResetResponse resetResponse = new(Configuration.Action as ResetRequest, Status: ResetStatus.Rejected);
                    Log.Add($"Sending 'ResetResponse' with status '{ResetStatus.Rejected}'...");
                    await SendMessageAsync(resetResponse, "Reset");
                    break;
                case OcppAction.RemoteStopTransaction:
                    RemoteStopTransactionResponse remoteStopTransactionResponse = new(Configuration.Action as RemoteStopTransactionRequest, Status: RemoteStartStopStatus.Rejected);
                    Log.Add($"Sending 'RemoteStopTransactionResponse' with status '{RemoteStartStopStatus.Rejected}'...");
                    await SendMessageAsync(remoteStopTransactionResponse, "RemoteStopTransaction");
                    break;

            }

            Configuration.ShowingChoiceDialog = false;
        }


        public async Task AcceptMessage()
        {
            IAction action;


            switch (Configuration.OcppMessage.Action)
            {
                case OcppAction.TriggerMessage:
                    TriggerMessageResponse triggerResponse = Configuration.Action as TriggerMessageResponse;
                    OcppAction? operation = triggerResponse.Operation;
                    Log.Add($"Sending 'TriggerMessage' {TriggerMessageStatus.Accepted}...");

                    action = triggerResponse;
                    await SendTriggerMessageAsync(action as TriggerMessageResponse, true);

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

                    break;
                case OcppAction.ClearCache:
                    action = Configuration.Action;
                    Log.Add($"Sending 'ClearCache' {ClearCacheStatus.Accepted}...");
                    await SendClearCacheAsync(action as ClearCacheResponse, true);
                    break;
                case OcppAction.DataTransfer:
                    DataTransferResponse dataTransferResponse = new(Configuration.Action as DataTransferRequest, Status: DataTransferStatus.Accepted);
                    Log.Add($"Sending 'DataTransferResponse' with status '{DataTransferStatus.Accepted}'...");
                    await SendMessageAsync(dataTransferResponse, "DataTransfer");
                    break;
                case OcppAction.Reset:
                    ResetResponse resetResponse = new(Configuration.Action as ResetRequest, Status: ResetStatus.Accepted);
                    Log.Add($"Sending 'ResetResponse' with status '{ResetStatus.Accepted}'...");
                    await SendMessageAsync(resetResponse as ResetResponse, "Reset");
                    break;
                case OcppAction.RemoteStopTransaction:
                    RemoteStopTransactionResponse remoteStopTransactionResponse = new(Configuration.Action as RemoteStopTransactionRequest, Status: RemoteStartStopStatus.Accepted);
                    Log.Add($"Sending 'RemoteStopTransactionResponse' with status '{RemoteStartStopStatus.Accepted}'...");
                    await SendMessageAsync(remoteStopTransactionResponse, "RemoteStopTransaction");
                    await SendStopTransactionAsync();
                    break;

            }
            Configuration.ShowingChoiceDialog = false;
        }

        public void Dispose()
        {
            _sendTokenSource.Cancel();
            _ = _socket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Bye", CancellationToken.None);

            GC.SuppressFinalize(this);
        }
    }
}
