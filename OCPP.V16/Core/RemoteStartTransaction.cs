namespace OCPP.Core
{



    public partial class RemoteStartTransactionRequest 
    {
        //[Newtonsoft.Json.JsonProperty("connectorId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ConnectorId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("idTag", Required = Newtonsoft.Json.Required.Always)]
        public string IdTag { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("chargingProfile", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ChargingProfile ChargingProfile { get; set; }
    
    
    }
}