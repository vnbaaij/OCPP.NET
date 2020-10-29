namespace OCPP
{
    /// <summary>Charging_ Profile
    /// urn:x-oca:ocpp:uid:2:233255
    /// A ChargingProfile consists of ChargingSchedule, describing the amount of power or current that can be delivered per time interval.
    /// </summary>

    public partial class ChargingProfileCriterion 
    {
        //[Newtonsoft.Json.JsonProperty("chargingProfilePurpose", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChargingProfilePurpose ChargingProfilePurpose { get; set; }
    
        /// <summary>Charging_ Profile. Stack_ Level. Counter
        /// urn:x-oca:ocpp:uid:1:569230
        /// Value determining level in hierarchy stack of profiles. Higher values have precedence over lower values. Lowest level is 0.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("stackLevel", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int StackLevel { get; set; }
    
        /// <summary>List of all the chargingProfileIds requested. Any ChargingProfile that matches one of these profiles will be reported. If omitted, the Charging Station SHALL not filter on chargingProfileId. This field SHALL NOT contain more ids than set in &amp;lt;&amp;lt;configkey-charging-profile-entries,ChargingProfileEntries.maxLimit&amp;gt;&amp;gt;
        /// 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("chargingProfileId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<int> ChargingProfileId { get; set; }
    
        /// <summary>For which charging limit sources, charging profiles SHALL be reported. If omitted, the Charging Station SHALL not filter on chargingLimitSource.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("chargingLimitSource", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore, ItemConverter = of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public System.Collections.Generic.ICollection<ChargingLimitSource> ChargingLimitSource { get; set; }
    }
}