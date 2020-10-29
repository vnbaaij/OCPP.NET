namespace OCPP
{


    public partial class GetMonitoringReportRequest
    {
        
    
        //[Newtonsoft.Json.JsonProperty("componentVariable", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ComponentVariable> ComponentVariable { get; set; }
    
        /// <summary>The Id of the request.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("requestId", Required = Newtonsoft.Json.Required.Always)]
        public int RequestId { get; set; }
    
        /// <summary>This field contains criteria for components for which a monitoring report is requested
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("monitoringCriteria", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore, ItemConverter = of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public System.Collections.Generic.ICollection<MonitoringCriterion> MonitoringCriteria { get; set; }
    
    
    }
}