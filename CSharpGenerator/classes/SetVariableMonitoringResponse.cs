namespace OCPP
{
    public partial class SetVariableMonitoringResponse
    {
        //[Newtonsoft.Json.JsonProperty("setMonitoringResult", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<SetMonitoringResult> SetMonitoringResult { get; set; } = new System.Collections.ObjectModel.Collection<SetMonitoringResult>();
    }
}