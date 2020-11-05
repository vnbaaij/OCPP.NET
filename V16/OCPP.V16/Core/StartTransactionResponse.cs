namespace OCPP.V16.Core
{

    public partial class StartTransactionResponse : ResponseBase<StartTransactionRequest, StartTransactionResponse>
    {
        ////[Newtonsoft.Json.JsonProperty("idTagInfo", Required = Newtonsoft.Json.Required.Always)]
        public IdTagInfo IdTagInfo { get; set; } = new IdTagInfo();

        ////[Newtonsoft.Json.JsonProperty("transactionId", Required = Newtonsoft.Json.Required.Always)]
        public int TransactionId { get; set; }

        /// <summary>
        /// Create a response.
        /// </summary>
        /// <param name="request">The request leading to this response.</param>
        /// <param name="result">The result.</param>
        public StartTransactionResponse(StartTransactionRequest request, Result result) : base(request, result)
        {

        }
    }
}
