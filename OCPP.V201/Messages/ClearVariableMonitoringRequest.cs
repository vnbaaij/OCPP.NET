using OCPP.Core;

namespace OCPP.V201
{
    public partial class ClearVariableMonitoringRequest : RequestBase<ClearVariableMonitoringRequest>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }


        /// <summary>List of the monitors to be cleared, identified by there Id.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<int> Id { get; set; } = new System.Collections.ObjectModel.Collection<int>();


    }
}