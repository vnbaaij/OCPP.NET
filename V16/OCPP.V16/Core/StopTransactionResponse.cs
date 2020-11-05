namespace OCPP.V16.Core
{
    public partial class StopTransactionResponse : ResponseBase<StopTransactionRequest, StopTransactionResponse>
    {
        ////[Newtonsoft.Json.JsonProperty("idTagInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IdTagInfo IdTagInfo { get; set; }

         /// <summary>
        /// Create a StopTransaction response.
        /// </summary>
        /// <param name="request">The StopTransaction request leading to this response.</param>
        /// <param name="result">The result.</param>
        public StopTransactionResponse(StopTransactionRequest request, Result result) : base(request, result)
        {

        }
    }
}
