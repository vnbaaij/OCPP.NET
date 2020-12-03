using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPP.V16.Core
{
    public record AuthorizeRequest(string IdTag) : RequestBase<AuthorizeRequest>;
    public record BootNotificationRequest(string ChargePointVendor, string ChargePointModel, string ChargePointSerialNumber = null, string ChargeBoxSerialNumber = null, string FirmwareVersion = null, string Iccid = null, string Imsi = null, string MeterType = null, string MeterSerialNumber = null) : RequestBase<BootNotificationRequest>;
    public record ChangeAvailabilityRequest(int ConnectorId, AvailabilityType Type) : RequestBase<ChangeAvailabilityRequest>;
    public record ChangeConfigurationRequest(string Key, string Value) : RequestBase<ChangeConfigurationRequest>;
    public record DataTransferRequest(string VendorId, string MessageId = null, string Data = null) : RequestBase<DataTransferRequest>;
    public record GetConfigurationRequest(ICollection<string> Key = null) : RequestBase<GetConfigurationRequest>;
    public record HeartbeatRequest() : RequestBase<HeartbeatRequest>;
    public record MeterValuesRequest(int ConnectorId, ICollection<MeterValue> MeterValues, int? TransactionId = null) : RequestBase<MeterValuesRequest>;
    public record RemoteStartTransactionRequest(string IdTag, int? ConnectorId = null, ChargingProfile ChargingProfile = null) : RequestBase<RemoteStartTransactionRequest>;
    public record RemoteStopTransactionRequest(int TransactionId) : RequestBase<RemoteStopTransactionRequest>;
    public record ResetRequest(ResetType Type) : RequestBase<ResetRequest>;
    public record StartTransactionRequest(int ConnectorId, string IdTag, int MeterStart, DateTime Timestamp, int? ReservationId = null) : RequestBase<StartTransactionRequest>;
    public record StatusNotificationRequest(int ConnectorId, ChargePointErrorCode ErrorCode, ChargePointStatus Status, string Info = null, DateTime? Timestamp = null, string VendorId = null, string VendorErrorCode = null) : RequestBase<StatusNotificationRequest>;
    public record StopTransactionRequest(int MeterStop, DateTime Timestamp, int TransactionId, string IdTag, Reason Reason, ICollection<MeterValue> TransactionData) : RequestBase<StopTransactionRequest>;
    public record UnlockConnectorRequest(int ConnectorId) : RequestBase<UnlockConnectorRequest>;
}
