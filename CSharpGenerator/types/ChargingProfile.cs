namespace OCPP
{
    /// <summary>Charging_ Profile
    /// urn:x-oca:ocpp:uid:2:233255
    /// A ChargingProfile consists of ChargingSchedule, describing the amount of power or current that can be delivered per time interval.
    /// </summary>

    public partial class ChargingProfile 
    {
        
    
        /// <summary>Identified_ Object. MRID. Numeric_ Identifier
        /// urn:x-enexis:ecdm:uid:1:569198
        /// Id of ChargingProfile.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public int Id { get; set; }
    
        /// <summary>Charging_ Profile. Stack_ Level. Counter
        /// urn:x-oca:ocpp:uid:1:569230
        /// Value determining level in hierarchy stack of profiles. Higher values have precedence over lower values. Lowest level is 0.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("stackLevel", Required = Newtonsoft.Json.Required.Always)]
        public int StackLevel { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("chargingProfilePurpose", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChargingProfilePurpose ChargingProfilePurpose { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("chargingProfileKind", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChargingProfileKind ChargingProfileKind { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("recurrencyKind", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RecurrencyKind RecurrencyKind { get; set; }
    
        /// <summary>Charging_ Profile. Valid_ From. Date_ Time
        /// urn:x-oca:ocpp:uid:1:569234
        /// Point in time at which the profile starts to be valid. If absent, the profile is valid as soon as it is received by the Charging Station.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("validFrom", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ValidFrom { get; set; }
    
        /// <summary>Charging_ Profile. Valid_ To. Date_ Time
        /// urn:x-oca:ocpp:uid:1:569235
        /// Point in time at which the profile stops to be valid. If absent, the profile is valid until it is replaced by another profile.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("validTo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ValidTo { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("chargingSchedule", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<ChargingSchedule> ChargingSchedule { get; set; } = new System.Collections.ObjectModel.Collection<ChargingSchedule>();
    
        /// <summary>SHALL only be included if ChargingProfilePurpose is set to TxProfile. The transactionId is used to match the profile to a specific transaction.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("transactionId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TransactionId { get; set; }
    
    
    }
}