using System.Collections.Generic;
namespace OCPP.V16.Core
{
    public record MeterValuesRequest(int ConnectorId, ICollection<MeterValue> MeterValues, int? TransactionId = null) : RequestBase<MeterValuesRequest>; 
    
}