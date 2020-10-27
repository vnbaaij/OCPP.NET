





namespace OCPP
{
    #pragma warning disable // Disable all warnings

    /// <summary>This class does not get 'AdditionalProperties = false' in the schema generation, so it can be extended with arbitrary JSON properties to allow adding custom data.</summary>
    
    public partial class CustomDataType 
    {
        //[Newtonsoft.Json.JsonProperty("vendorId", Required = Newtonsoft.Json.Required.Always)]
        public string VendorId { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        //[Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    
    public enum ChargingLimitSourceEnumType
    {
        
        EMS = 0,
    
        
        Other = 1,
    
        
        SO = 2,
    
        
        CSO = 3,
    
    }
    
    /// <summary>Charging_ Profile. Charging_ Profile_ Purpose. Charging_ Profile_ Purpose_ Code
    /// urn:x-oca:ocpp:uid:1:569231
    /// Defines the purpose of the schedule transferred by this profile
    /// </summary>
    
    public enum ChargingProfilePurposeEnumType
    {
        
        ChargingStationExternalConstraints = 0,
    
        
        ChargingStationMaxProfile = 1,
    
        
        TxDefaultProfile = 2,
    
        
        TxProfile = 3,
    
    }
    
    /// <summary>Charging_ Profile
    /// urn:x-oca:ocpp:uid:2:233255
    /// A ChargingProfile consists of ChargingSchedule, describing the amount of power or current that can be delivered per time interval.
    /// </summary>
    
    public partial class ChargingProfileCriterionType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("chargingProfilePurpose", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChargingProfilePurposeEnumType ChargingProfilePurpose { get; set; }
    
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
        //[Newtonsoft.Json.JsonProperty("chargingLimitSource", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public System.Collections.Generic.ICollection<ChargingLimitSourceEnumType> ChargingLimitSource { get; set; }
    
    
    }
    
    
    public partial class Anonymous 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Reference identification that is to be used by the Charging Station in the &amp;lt;&amp;lt;reportchargingprofilesrequest, ReportChargingProfilesRequest&amp;gt;&amp;gt; when provided.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("requestId", Required = Newtonsoft.Json.Required.Always)]
        public int RequestId { get; set; }
    
        /// <summary>For which EVSE installed charging profiles SHALL be reported. If 0, only charging profiles installed on the Charging Station itself (the grid connection) SHALL be reported. If omitted, all installed charging profiles SHALL be reported.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("evseId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int EvseId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("chargingProfile", Required = Newtonsoft.Json.Required.Always)]
        public ChargingProfileCriterionType ChargingProfile { get; set; } = new ChargingProfileCriterionType();
    
    
    }
}