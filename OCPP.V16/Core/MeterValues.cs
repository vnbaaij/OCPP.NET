namespace OCPP.Core
{
    public partial class MeterValuesRequest 
    {
        //[Newtonsoft.Json.JsonProperty("connectorId", Required = Newtonsoft.Json.Required.Always)]
        public int ConnectorId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("transactionId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int TransactionId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("meterValue", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<MeterValue> MeterValue { get; set; } = new System.Collections.ObjectModel.Collection<MeterValue>();
    
    
    }
}