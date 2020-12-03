using OCPP.V16;

namespace OCPP.V16.RemoteTrigger
{
    public record TriggerMessageRequest : RequestBase<TriggerMessageRequest> 
    {
        //[Newtonsoft.Json.JsonProperty("requestedMessage", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MessageTrigger RequestedMessage { get; set; }

        //[Newtonsoft.Json.JsonProperty("connectorId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ConnectorId { get; set; }
    }
}