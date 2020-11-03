using OCPP.V16;

namespace OCPP.V16.Core
{
    public partial class StartTransactionRequest : RequestBase<StartTransactionRequest> 
    {
        //[Newtonsoft.Json.JsonProperty("connectorId", Required = Newtonsoft.Json.Required.Always)]
        public int ConnectorId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("idTag", Required = Newtonsoft.Json.Required.Always)]
        public string IdTag { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("meterStart", Required = Newtonsoft.Json.Required.Always)]
        public int MeterStart { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("reservationId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ReservationId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset Timestamp { get; set; }
    }
}