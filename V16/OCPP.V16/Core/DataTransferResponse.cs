namespace OCPP.V16.Core
{



    public partial class DataTransferResponse : ResponseBase<DataTransferRequest, DataTransferResponse>
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        ////[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DataTransferResponseStatus Status { get; set; }

        //[Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Data { get; set; }

        /// <summary>
        /// Create a response.
        /// </summary>
        /// <param name="request">The request leading to this response.</param>
        /// <param name="result">The result.</param>
        public DataTransferResponse(DataTransferRequest request, Result result) : base(request, result)
        {

        }
    }
}