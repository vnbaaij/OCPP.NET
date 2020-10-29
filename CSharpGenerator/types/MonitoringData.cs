namespace OCPP
{
    /// <summary>Class to hold parameters of SetVariableMonitoring request.
    /// </summary>

    public partial class MonitoringData 
    {
        
    
        //[Newtonsoft.Json.JsonProperty("component", Required = Newtonsoft.Json.Required.Always)]
        public Component Component { get; set; } = new Component();
    
        //[Newtonsoft.Json.JsonProperty("variable", Required = Newtonsoft.Json.Required.Always)]
        public Variable Variable { get; set; } = new Variable();
    
        //[Newtonsoft.Json.JsonProperty("variableMonitoring", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<VariableMonitoring> VariableMonitoring { get; set; } = new System.Collections.ObjectModel.Collection<VariableMonitoring>();
    
    
    }
}