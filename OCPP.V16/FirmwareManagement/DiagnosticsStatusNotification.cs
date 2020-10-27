namespace OCPP.FirmwareManagement
{
    public partial class DiagnosticsStatusNotificationRequest 
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DiagnosticsStatusNotificationRequestStatus Status { get; set; }
    }
}