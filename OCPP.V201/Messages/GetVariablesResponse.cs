using OCPP.V201.Core;

namespace OCPP.V201
{
    public partial class GetVariablesResponse : ResponseBase<GetVariablesRequest,GetVariablesResponse>    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        //[Newtonsoft.Json.JsonProperty("getVariableResult", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<GetVariableResult> GetVariableResult { get; set; } = new System.Collections.ObjectModel.Collection<GetVariableResult>();

        public GetVariablesResponse(GetVariablesRequest request,Result result)  : base(request, result)
        {

        }
    }
}