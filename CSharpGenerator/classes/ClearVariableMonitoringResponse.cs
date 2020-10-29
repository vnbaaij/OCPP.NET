namespace OCPP
{

    public partial class ClearVariableMonitoringResponse
    {
        //[Newtonsoft.Json.JsonProperty("clearMonitoringResult", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<ClearMonitoringResult> ClearMonitoringResult { get; set; } = new System.Collections.ObjectModel.Collection<ClearMonitoringResult>();
    }
}