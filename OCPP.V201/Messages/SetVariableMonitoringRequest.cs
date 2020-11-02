using OCPP.Core;

namespace OCPP.V201
{
    public partial class SetVariableMonitoringRequest : RequestBase<SetVariableMonitoringRequest>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        //[Newtonsoft.Json.JsonProperty("setMonitoringData", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<SetMonitoringData> SetMonitoringData { get; set; } = new System.Collections.ObjectModel.Collection<SetMonitoringData>();
    }
}