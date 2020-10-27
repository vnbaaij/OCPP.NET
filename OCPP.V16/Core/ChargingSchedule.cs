namespace OCPP.Core
{
    public partial class ChargingSchedule 
    {
        //[Newtonsoft.Json.JsonProperty("duration", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Duration { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("startSchedule", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset StartSchedule { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("chargingRateUnit", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChargingScheduleChargingRateUnit ChargingRateUnit { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("chargingSchedulePeriod", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<ChargingSchedulePeriod> ChargingSchedulePeriod { get; set; } = new System.Collections.ObjectModel.Collection<ChargingSchedulePeriod>();
    
        //[Newtonsoft.Json.JsonProperty("minChargingRate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double MinChargingRate { get; set; }
    
    
    }
}