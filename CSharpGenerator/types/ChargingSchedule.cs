namespace OCPP
{
    /// <summary>Charging_ Schedule
    /// urn:x-oca:ocpp:uid:2:233256
    /// Charging schedule structure defines a list of charging periods, as used in: GetCompositeSchedule.conf and ChargingProfile. 
    /// </summary>

    public partial class ChargingSchedule 
    {
        /// <summary>Identifies the ChargingSchedule.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public int Id { get; set; }
    
        /// <summary>Charging_ Schedule. Start_ Schedule. Date_ Time
        /// urn:x-oca:ocpp:uid:1:569237
        /// Starting point of an absolute schedule. If absent the schedule will be relative to start of charging.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("startSchedule", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset StartSchedule { get; set; }
    
        /// <summary>Charging_ Schedule. Duration. Elapsed_ Time
        /// urn:x-oca:ocpp:uid:1:569236
        /// Duration of the charging schedule in seconds. If the duration is left empty, the last period will continue indefinitely or until end of the transaction if chargingProfilePurpose = TxProfile.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("duration", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Duration { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("chargingRateUnit", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChargingRateUnit ChargingRateUnit { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("chargingSchedulePeriod", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<ChargingSchedulePeriod> ChargingSchedulePeriod { get; set; } = new System.Collections.ObjectModel.Collection<ChargingSchedulePeriod>();
    
        /// <summary>Charging_ Schedule. Min_ Charging_ Rate. Numeric
        /// urn:x-oca:ocpp:uid:1:569239
        /// Minimum charging rate supported by the EV. The unit of measure is defined by the chargingRateUnit. This parameter is intended to be used by a local smart charging algorithm to optimize the power allocation for in the case a charging process is inefficient at lower charging rates. Accepts at most one digit fraction (e.g. 8.1)
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("minChargingRate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double MinChargingRate { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("salesTariff", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SalesTariff SalesTariff { get; set; }
    }
}