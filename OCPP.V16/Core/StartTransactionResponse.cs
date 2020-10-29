using OCPP.Core;

namespace OCPP.Core
{
    
    public partial class StartTransactionResponse 
    {
        ////[Newtonsoft.Json.JsonProperty("idTagInfo", Required = Newtonsoft.Json.Required.Always)]
        public IdTagInfo IdTagInfo { get; set; } = new IdTagInfo();
    
        ////[Newtonsoft.Json.JsonProperty("transactionId", Required = Newtonsoft.Json.Required.Always)]
        public int TransactionId { get; set; }
    
    }
}