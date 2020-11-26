namespace OCPP.V16.Core
{

    public partial class HeartbeatResponse : ResponseBase<HeartbeatResponse>
    {
        //[Newtonsoft.Json.JsonProperty("currentTime", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTime CurrentTime { get; set; }

         /// <summary>
        /// Create a Heartbeat response.
        /// </summary>
        /// <param name="request">The Heartbeat request leading to this response.</param>
        /// <param name="result">The result.</param>
        public HeartbeatResponse() : base()
        {

        }
    }
}
