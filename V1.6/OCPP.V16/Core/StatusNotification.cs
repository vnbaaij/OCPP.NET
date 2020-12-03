using System;

namespace OCPP.V16.Core
{
    public record StatusNotificationRequest(int ConnectorId, ChargePointErrorCode ErrorCode, ChargePointStatus Status, string Info = null, DateTime? Timestamp = null, string VendorId = null, string VendorErrorCode = null) : RequestBase<StatusNotificationRequest>; 

}