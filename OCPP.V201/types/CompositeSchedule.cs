namespace OCPP
{
    /// <summary>Composite_ Schedule
    /// urn:x-oca:ocpp:uid:2:233362
    /// </summary>

    public partial class CompositeSchedule 
    {
        //[Newtonsoft.Json.JsonProperty("chargingSchedulePeriod", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<ChargingSchedulePeriod> ChargingSchedulePeriod { get; set; } = new System.Collections.ObjectModel.Collection<ChargingSchedulePeriod>();
    
        /// <summary>The ID of the EVSE for which the
        /// schedule is requested. When evseid=0, the
        /// Charging Station calculated the expected
        /// consumption for the grid connection.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("evseId", Required = Newtonsoft.Json.Required.Always)]
        public int EvseId { get; set; }
    
        /// <summary>Duration of the schedule in seconds.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("duration", Required = Newtonsoft.Json.Required.Always)]
        public int Duration { get; set; }
    
        /// <summary>Composite_ Schedule. Start. Date_ Time
        /// urn:x-oca:ocpp:uid:1:569456
        /// Date and time at which the schedule becomes active. All time measurements within the schedule are relative to this timestamp.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("scheduleStart", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset ScheduleStart { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("chargingRateUnit", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChargingRateUnit ChargingRateUnit { get; set; }
    }
}