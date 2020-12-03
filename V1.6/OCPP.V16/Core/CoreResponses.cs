using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPP.V16.Core
{
    public record AuthorizeResponse(AuthorizeRequest Request, IdTagInfo IdTagInfo) : ResponseBase<AuthorizeRequest, AuthorizeResponse>(Request);
    public record BootNotificationResponse(BootNotificationRequest Request, DateTime CurrentTime, RegistrationStatus Status, int Interval) : ResponseBase<BootNotificationRequest, BootNotificationResponse>(Request);
    public record ChangeAvailabilityResponse(ChangeAvailabilityRequest Request, AvailabilityStatus Status) : ResponseBase<ChangeAvailabilityRequest, ChangeAvailabilityResponse>(Request);
    public record ChangeConfigurationResponse(ChangeConfigurationRequest Request, ConfigurationStatus Status) : ResponseBase<ChangeConfigurationRequest, ChangeConfigurationResponse>(Request);
    public record ClearCacheResponse(ClearCacheStatus Status) : ResponseBase<ClearCacheResponse>;
    public record DataTransferResponse(DataTransferRequest Request, DataTransferStatus Status, string Data) : ResponseBase<DataTransferRequest, DataTransferResponse>(Request);
    public record GetConfigurationResponse(GetConfigurationRequest Request, ICollection<ConfigurationKey> ConfigurationKey, ICollection<string> UnknownKey) : ResponseBase<GetConfigurationRequest, GetConfigurationResponse>(Request);
    public record HeartbeatResponse(DateTime CurrentTime) : ResponseBase<HeartbeatResponse>;
    public record RemoteStartTransactionResponse(RemoteStartTransactionRequest Request, RemoteStartStopStatus Status) : ResponseBase<RemoteStartTransactionRequest, RemoteStartTransactionResponse>(Request);
    public record RemoteStopTransactionResponse(RemoteStopTransactionRequest Request, RemoteStartStopStatus Status) : ResponseBase<RemoteStopTransactionRequest, RemoteStopTransactionResponse>(Request);
    public record ResetResponse(ResetRequest Request, ResetStatus Status) : ResponseBase<ResetRequest, ResetResponse>(Request);
    public record StartTransactionResponse(StartTransactionRequest Request, IdTagInfo IdTagInfo, int TransactionId) : ResponseBase<StartTransactionRequest, StartTransactionResponse>(Request);
    public record StopTransactionResponse(StopTransactionRequest Request, IdTagInfo IdTagInfo) : ResponseBase<StopTransactionRequest, StopTransactionResponse>(Request);
    public record UnlockConnectorResponse(UnlockConnectorRequest Request, UnlockStatus Status) : ResponseBase<UnlockConnectorRequest, UnlockConnectorResponse>(Request);
}
