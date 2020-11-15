namespace OCPP.V16.Core
{



    public partial class UnlockConnectorResponse : ResponseBase<UnlockConnectorRequest, UnlockConnectorResponse>
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public UnlockConnectorResponseStatus Status { get; set; }

         /// <summary>
        /// Create a UnlockConnector response.
        /// </summary>
        /// <param name="request">The UnlockConnector request leading to this response.</param>
        /// <param name="result">The result.</param>
        public UnlockConnectorResponse(UnlockConnectorRequest request) : base(request)
        {

        }
    }
}
