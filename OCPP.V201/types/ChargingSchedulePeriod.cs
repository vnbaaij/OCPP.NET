namespace OCPP
{
    /// <summary>Charging_ Schedule_ Period
    /// urn:x-oca:ocpp:uid:2:233257
    /// Charging schedule period structure defines a time period in a charging schedule.
    /// </summary>

    public partial class ChargingSchedulePeriod
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomData CustomData { get; set; }

        /// <summary>Charging_ Schedule_ Period. Start_ Period. Elapsed_ Time
        /// urn:x-oca:ocpp:uid:1:569240
        /// Start of the period, in seconds from the start of schedule. The value of StartPeriod also defines the stop time of the previous period.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("startPeriod", Required = Newtonsoft.Json.Required.Always)]
        public int StartPeriod { get; set; }

        /// <summary>Charging_ Schedule_ Period. Limit. Measure
        /// urn:x-oca:ocpp:uid:1:569241
        /// Charging rate limit during the schedule period, in the applicable chargingRateUnit, for example in Amperes (A) or Watts (W). Accepts at most one digit fraction (e.g. 8.1).
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("limit", Required = Newtonsoft.Json.Required.Always)]
        public double Limit { get; set; }

        /// <summary>Charging_ Schedule_ Period. Number_ Phases. Counter
        /// urn:x-oca:ocpp:uid:1:569242
        /// The number of phases that can be used for charging. If a number of phases is needed, numberPhases=3 will be assumed unless another number is given.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("numberPhases", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int NumberPhases { get; set; }

        /// <summary>Values: 1..3, Used if numberPhases=1 and if the EVSE is capable of switching the phase connected to the EV, i.e. ACPhaseSwitchingSupported is defined and true. It’s not allowed unless both conditions above are true. If both conditions are true, and phaseToUse is omitted, the Charging Station / EVSE will make the selection on its own.
        ///
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("phaseToUse", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int PhaseToUse { get; set; }


    }
}