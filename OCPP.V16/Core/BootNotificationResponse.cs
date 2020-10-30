namespace OCPP.V16.Core
{
    public partial class BootNotificationResponse
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        ////[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public BootNotificationResponseStatus Status { get; set; }

        //[Newtonsoft.Json.JsonProperty("currentTime", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset CurrentTime { get; set; }

        //[Newtonsoft.Json.JsonProperty("interval", Required = Newtonsoft.Json.Required.Always)]
        public int Interval { get; set; }

    }
}