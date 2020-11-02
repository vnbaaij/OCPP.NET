using OCPP.Core;

namespace OCPP.V201
{
    public partial class GetVariablesRequest : RequestBase<GetVariablesRequest>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        //[Newtonsoft.Json.JsonProperty("getVariableData", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<GetVariableData> GetVariableData { get; set; } = new System.Collections.ObjectModel.Collection<GetVariableData>();
    }
}