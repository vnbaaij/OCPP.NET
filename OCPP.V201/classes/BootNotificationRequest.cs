namespace OCPP
{
    public partial class BootNotificationRequest
    {

        //[Newtonsoft.Json.JsonProperty("chargingStation", Required = Newtonsoft.Json.Required.Always)]
        public ChargingStation ChargingStation { get; set; } = new ChargingStation();

        //[Newtonsoft.Json.JsonProperty("reason", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public BootReason Reason { get; set; }


    }
}