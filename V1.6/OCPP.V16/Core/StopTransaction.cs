
using System;
using System.Collections.Generic;

namespace OCPP.V16.Core
{
    public record StopTransactionRequest(int MeterStop, DateTime Timestamp, int TransactionId, string IdTag, Reason Reason, ICollection<MeterValue> TransactionData) : RequestBase<StopTransactionRequest>; 
}