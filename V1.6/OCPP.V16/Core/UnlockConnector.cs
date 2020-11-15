
namespace OCPP.V16.Core
{
    public partial class UnlockConnectorRequest : RequestBase<UnlockConnectorRequest> 
    {
        //[Newtonsoft.Json.JsonProperty("connectorId", Required = Newtonsoft.Json.Required.Always)]
        public int ConnectorId { get; set; }
    }
}