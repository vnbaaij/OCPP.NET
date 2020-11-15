using OCPP.V201.Core;

namespace OCPP.V201
{
    public partial class GetMonitoringReportRequest : RequestBase<GetMonitoringReportRequest>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
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