using OCPP.Core;

namespace OCPP.V201
{
    public partial class HeartbeatResponse : ResponseBase<HeartbeatRequest, HeartbeatResponse>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        /// <summary>Contains the current time of the CSMS.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("currentTime", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset CurrentTime { get; set; }

        public HeartbeatResponse(HeartbeatRequest request, Result result) : base(request, result)
        {

        }
    }
}