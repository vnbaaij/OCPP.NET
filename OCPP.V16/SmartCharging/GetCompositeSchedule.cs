namespace OCPP.SmartCharging
{



    public partial class GetCompositeScheduleRequest 
    {
        //[Newtonsoft.Json.JsonProperty("connectorId", Required = Newtonsoft.Json.Required.Always)]
        public int ConnectorId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("duration", Required = Newtonsoft.Json.Required.Always)]
        public int Duration { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("chargingRateUnit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GetCompositeScheduleRequestChargingRateUnit ChargingRateUnit { get; set; }
    
    
    }
}