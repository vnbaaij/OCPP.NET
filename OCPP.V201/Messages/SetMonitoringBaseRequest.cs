using OCPP.V201.Core;

namespace OCPP.V201
{
    public partial class SetMonitoringBaseRequest : RequestBase<SetMonitoringBaseRequest>    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        //[Newtonsoft.Json.JsonProperty("monitoringBase", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MonitoringBase MonitoringBase { get; set; }
    }
}