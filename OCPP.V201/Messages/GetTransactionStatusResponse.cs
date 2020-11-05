using OCPP.V201.Core;

namespace OCPP.V201
{
    public partial class GetTransactionStatusResponse : ResponseBase<GetTransactionStatusRequest, GetTransactionStatusResponse>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        /// <summary>Whether the transaction is still ongoing.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("ongoingIndicator", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool OngoingIndicator { get; set; }

        /// <summary>Whether there are still message to be delivered.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("messagesInQueue", Required = Newtonsoft.Json.Required.Always)]
        public bool MessagesInQueue { get; set; }

        public GetTransactionStatusResponse(GetTransactionStatusRequest request, Result result) : base(request, result)
        {

        }
    }
}