namespace OCPP
{
    public partial class TriggerMessageRequest
    {
        //[Newtonsoft.Json.JsonProperty("evse", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EVSE Evse { get; set; }

        //[Newtonsoft.Json.JsonProperty("requestedMessage", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MessageTrigger RequestedMessage { get; set; }
    }
}