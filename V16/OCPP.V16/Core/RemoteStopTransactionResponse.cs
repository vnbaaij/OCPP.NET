namespace OCPP.V16.Core
{



    public partial class RemoteStopTransactionResponse : ResponseBase<RemoteStopTransactionRequest, RemoteStopTransactionResponse>
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RemoteStopTransactionResponseStatus Status { get; set; }

         /// <summary>
        /// Create a RemoteStopTransaction response.
        /// </summary>
        /// <param name="request">The RemoteStopTransaction request leading to this response.</param>
        /// <param name="result">The result.</param>
        public RemoteStopTransactionResponse(RemoteStopTransactionRequest request, Result result) : base(request, result)
        {

        }
    }
}