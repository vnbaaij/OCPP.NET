namespace OCPP
{
    public partial class SetVariableMonitoringRequest
    {
        //[Newtonsoft.Json.JsonProperty("setMonitoringData", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<SetMonitoringData> SetMonitoringData { get; set; } = new System.Collections.ObjectModel.Collection<SetMonitoringData>();
    }
}