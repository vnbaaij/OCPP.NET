using OCPP.Core;

namespace OCPP.V201
{
    public partial class RequestStopTransactionRequest : RequestBase<RequestStopTransactionRequest>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        /// <summary>The identifier of the transaction which the Charging Station is requested to stop.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("transactionId", Required = Newtonsoft.Json.Required.Always)]
        public string TransactionId { get; set; }
    }
}