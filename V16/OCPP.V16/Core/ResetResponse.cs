namespace OCPP.V16.Core
{
    public partial class ResetResponse
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ResetResponseStatus Status { get; set; }
    }
}