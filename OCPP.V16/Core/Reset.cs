namespace OCPP.Core
{
    public partial class ResetRequest
    {
        //[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ResetRequestType Type { get; set; }
    }
}