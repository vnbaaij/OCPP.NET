using OCPP.V16;

namespace OCPP.V16.FirmwareManagement
{
    public partial class GetDiagnosticsRequest : RequestBase<GetDiagnosticsRequest> 
    {
        //[Newtonsoft.Json.JsonProperty("location", Required = Newtonsoft.Json.Required.Always)]
        public System.Uri Location { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("retries", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Retries { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("retryInterval", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RetryInterval { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("startTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset StartTime { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("stopTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset StopTime { get; set; }
    }
}