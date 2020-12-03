
namespace OCPP.V16.Core
{
    public record RemoteStartTransactionRequest(string IdTag, int? ConnectorId = null, ChargingProfile ChargingProfile = null) : RequestBase<RemoteStartTransactionRequest>; 
   
}