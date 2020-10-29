using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace OCPP
{
    public partial class SetVariablesRequest
    {
        //[Newtonsoft.Json.JsonProperty("setVariableData", Required = Newtonsoft.Json.Required.Always)]
        public ICollection<SetVariableData> SetVariableData { get; set; } = new Collection<SetVariableData>();
    }
}