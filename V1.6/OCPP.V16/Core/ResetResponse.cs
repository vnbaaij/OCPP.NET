namespace OCPP.V16.Core
{
    public partial class ResetResponse : ResponseBase<ResetRequest, ResetResponse>
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ResetResponseStatus Status { get; set; }

         /// <summary>
        /// Create a Reset response.
        /// </summary>
        /// <param name="request">The Reset request leading to this response.</param>
        /// <param name="result">The result.</param>
        public ResetResponse(ResetRequest request) : base(request)
        {

        }
    }
}