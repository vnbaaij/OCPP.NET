namespace OCPP
{

    public partial class UnpublishFirmwareResponse
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public UnpublishFirmwareStatus Status { get; set; }
    }
}