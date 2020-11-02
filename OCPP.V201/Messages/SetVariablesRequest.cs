using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using OCPP.Core;

namespace OCPP.V201
{
    public partial class SetVariablesRequest : RequestBase<SetVariablesRequest>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        //[Newtonsoft.Json.JsonProperty("setVariableData", Required = Newtonsoft.Json.Required.Always)]
        public ICollection<SetVariableData> SetVariableData { get; set; } = new Collection<SetVariableData>();
    }
}