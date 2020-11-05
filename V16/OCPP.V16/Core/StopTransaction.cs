using OCPP.V16;

namespace OCPP.V16.Core
{
    public partial class StopTransactionRequest : RequestBase<StopTransactionRequest> 
    {
        //[Newtonsoft.Json.JsonProperty("idTag", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IdTag { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("meterStop", Required = Newtonsoft.Json.Required.Always)]
        public int MeterStop { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset Timestamp { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("transactionId", Required = Newtonsoft.Json.Required.Always)]
        public int TransactionId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("reason", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public StopTransactionRequestReason Reason { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("transactionData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<TransactionData> TransactionData { get; set; }
    }
}