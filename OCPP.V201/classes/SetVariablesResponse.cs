namespace OCPP
{

    public partial class SetVariablesResponse
    {
        //[Newtonsoft.Json.JsonProperty("setVariableResult", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<SetVariableResult> SetVariableResult { get; set; } = new System.Collections.ObjectModel.Collection<SetVariableResult>();
    }
}