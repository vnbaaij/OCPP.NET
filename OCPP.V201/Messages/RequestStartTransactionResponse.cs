using OCPP.Core;

namespace OCPP.V201
{
    public partial class RequestStartTransactionResponse : ResponseBase<RequestStartTransactionRequest, RequestStartTransactionResponse>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RequestStartStopStatus Status { get; set; }

        //[Newtonsoft.Json.JsonProperty("statusInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public StatusInfo StatusInfo { get; set; }

        /// <summary>When the transaction was already started by the Charging Station before the RequestStartTransactionRequest was received, for example: cable plugged in first. This contains the transactionId of the already started transaction.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("transactionId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TransactionId { get; set; }
        public RequestStartTransactionResponse(RequestStartTransactionRequest request, Result result) : base(request, result)
        {

        }
    }
}