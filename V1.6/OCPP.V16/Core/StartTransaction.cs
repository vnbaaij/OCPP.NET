using System;

namespace OCPP.V16.Core
{
    public record StartTransactionRequest(int ConnectorId, string IdTag, int MeterStart, DateTime Timestamp, int? ReservationId = null) : RequestBase<StartTransactionRequest>; 
    
}