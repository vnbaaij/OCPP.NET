using OCPP.V201.Core;

namespace OCPP.V201
{
    public partial class SetVariablesResponse : ResponseBase<SetVariablesRequest,SetVariablesResponse>    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        //[Newtonsoft.Json.JsonProperty("setVariableResult", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<SetVariableResult> SetVariableResult { get; set; } = new System.Collections.ObjectModel.Collection<SetVariableResult>();

        public SetVariablesResponse(SetVariablesRequest request,Result result)  : base(request, result)
        {

        }
    }
}