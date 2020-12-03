using OCPP.V16;

namespace OCPP.V16.FirmwareManagement
{
    public record DiagnosticsStatusNotificationRequest : RequestBase<DiagnosticsStatusNotificationRequest> 
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DiagnosticsStatus Status { get; set; }
    }
}