namespace OCPP.V16.ListManagement
{



    public partial class SendLocalListResponse : ResponseBase<SendLocalListRequest, SendLocalListResponse>
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SendLocalListResponseStatus Status { get; set; }

         /// <summary>
        /// Create a SendLocalList response.
        /// </summary>
        /// <param name="request">The SendLocalList request leading to this response.</param>
        /// <param name="result">The result.</param>
        public SendLocalListResponse(SendLocalListRequest request) : base(request)
        {

        }
    }
}