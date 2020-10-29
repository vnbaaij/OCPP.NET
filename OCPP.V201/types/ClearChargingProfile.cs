namespace OCPP
{
    /// <summary>Charging_ Profile
    /// urn:x-oca:ocpp:uid:2:233255
    /// A ChargingProfile consists of a ChargingSchedule, describing the amount of power or current that can be delivered per time interval.
    /// </summary>

    public partial class ClearChargingProfile 
    {
        /// <summary>Identified_ Object. MRID. Numeric_ Identifier
        /// urn:x-enexis:ecdm:uid:1:569198
        /// Specifies the id of the EVSE for which to clear charging profiles. An evseId of zero (0) specifies the charging profile for the overall Charging Station. Absence of this parameter means the clearing applies to all charging profiles that match the other criteria in the request.
        /// 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("evseId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int EvseId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("chargingProfilePurpose", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChargingProfilePurpose ChargingProfilePurpose { get; set; }
    
        /// <summary>Charging_ Profile. Stack_ Level. Counter
        /// urn:x-oca:ocpp:uid:1:569230
        /// Specifies the stackLevel for which charging profiles will be cleared, if they meet the other criteria in the request.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("stackLevel", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int StackLevel { get; set; }
    }
}