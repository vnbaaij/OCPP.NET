namespace OCPP.V16.Core
{



    public partial class RemoteStartTransactionResponse : ResponseBase<RemoteStartTransactionRequest, RemoteStartTransactionResponse>
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RemoteStartTransactionResponseStatus Status { get; set; }

         /// <summary>
        /// Create a RemoteStartTransaction response.
        /// </summary>
        /// <param name="request">The RemoteStartTransaction request leading to this response.</param>
        /// <param name="result">The result.</param>
        public RemoteStartTransactionResponse(RemoteStartTransactionRequest request, Result result) : base(request, result)
        {

        }
    }
}
