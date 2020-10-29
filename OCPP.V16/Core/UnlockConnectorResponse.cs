namespace OCPP.Core
{



    public partial class UnlockConnectorResponse 
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public UnlockConnectorResponseStatus Status { get; set; }
    }
}