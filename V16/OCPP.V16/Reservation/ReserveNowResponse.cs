namespace OCPP.V16.Reservation
{
    public partial class ReserveNowResponse : ResponseBase<ReserveNowRequest, ReserveNowResponse>
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ReserveNowResponseStatus Status { get; set; }

        /// <summary>
        /// Create a response.
        /// </summary>
        /// <param name="request">The request leading to this response.</param>
        /// <param name="result">The result.</param>
        public ReserveNowResponse(ReserveNowRequest request, Result result) : base(request, result)
        {

        }
    }
}