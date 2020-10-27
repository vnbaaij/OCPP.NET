namespace OCPP.RemoteTrigger
{



    public partial class TriggerMessageResponse
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public TriggerMessageResponseStatus Status { get; set; }


    }
}