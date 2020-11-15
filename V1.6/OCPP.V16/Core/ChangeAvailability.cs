namespace OCPP.V16.Core
{
    public partial class ChangeAvailabilityRequest : RequestBase<ChangeAvailabilityRequest> 
    {
        //[Newtonsoft.Json.JsonProperty("connectorId", Required = Newtonsoft.Json.Required.Always)]
        public int ConnectorId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChangeAvailabilityRequestType Type { get; set; }
    }
}