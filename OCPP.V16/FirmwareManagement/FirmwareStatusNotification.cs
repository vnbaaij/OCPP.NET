namespace OCPP.FirmwareManagement
{
    public partial class FirmwareStatusNotificationRequest 
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FirmwareStatusNotificationRequestStatus Status { get; set; }
    }
}