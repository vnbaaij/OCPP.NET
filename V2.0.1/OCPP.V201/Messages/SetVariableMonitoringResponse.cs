using OCPP.V201.Core;

namespace OCPP.V201
{
    public partial class SetVariableMonitoringResponse : ResponseBase<SetVariableMonitoringRequest,SetVariableMonitoringResponse>    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        //[Newtonsoft.Json.JsonProperty("setMonitoringResult", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<SetMonitoringResult> SetMonitoringResult { get; set; } = new System.Collections.ObjectModel.Collection<SetMonitoringResult>();

        public SetVariableMonitoringResponse(SetVariableMonitoringRequest request,Result result)  : base(request, result)
        {

        }
    }
}