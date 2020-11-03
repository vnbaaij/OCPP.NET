using OCPP.V16;

namespace OCPP.V16.FirmwareManagement
{
    public partial class DiagnosticsStatusNotificationRequest : RequestBase<DiagnosticsStatusNotificationRequest> 
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DiagnosticsStatusNotificationRequestStatus Status { get; set; }
    }
}