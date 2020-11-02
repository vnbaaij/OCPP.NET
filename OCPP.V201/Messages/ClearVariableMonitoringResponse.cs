using OCPP.Core;

namespace OCPP.V201
{
    public partial class ClearVariableMonitoringResponse : ResponseBase<ClearVariableMonitoringRequest,ClearVariableMonitoringResponse>    
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        //[Newtonsoft.Json.JsonProperty("clearMonitoringResult", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<ClearMonitoringResult> ClearMonitoringResult { get; set; } = new System.Collections.ObjectModel.Collection<ClearMonitoringResult>();

        public ClearVariableMonitoringResponse(ClearVariableMonitoringRequest request,Result result)  : base(request, result)
        {

        }
    }
}