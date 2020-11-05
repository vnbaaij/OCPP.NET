namespace OCPP.V16.Core
{

    public partial class HeartbeatResponse : ResponseBase<HeartbeatResponse>
    {
        //[Newtonsoft.Json.JsonProperty("currentTime", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset CurrentTime { get; set; }

        /// <summary>
        /// Create a response.
        /// </summary>
        /// <param name="request">The request leading to this response.</param>
        /// <param name="result">The result.</param>
        public HeartbeatResponse(Result result) : base(result)
        {

        }
    }
}
