namespace OCPP
{

    
    
    
    
    
    
    
    public partial class NotifyChargingLimitRequest
    {
        
    
        //[Newtonsoft.Json.JsonProperty("chargingSchedule", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ChargingSchedule> ChargingSchedule { get; set; }
    
        /// <summary>The charging schedule contained in this notification applies to an EVSE. evseId must be &amp;gt; 0.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("evseId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int EvseId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("chargingLimit", Required = Newtonsoft.Json.Required.Always)]
        public ChargingLimit ChargingLimit { get; set; } = new ChargingLimit();
    
    
    }
}