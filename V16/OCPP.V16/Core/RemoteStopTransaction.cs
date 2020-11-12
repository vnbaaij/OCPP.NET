
namespace OCPP.V16.Core
{
    public partial class RemoteStopTransactionRequest : RequestBase<RemoteStopTransactionRequest>
    {
        //[Newtonsoft.Json.JsonProperty("transactionId", Required = Newtonsoft.Json.Required.Always)]
        public int TransactionId { get; set; }
    }
}