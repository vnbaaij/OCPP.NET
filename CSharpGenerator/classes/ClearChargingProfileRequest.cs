





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
    
    /// <summary>Charging_ Profile. Charging_ Profile_ Purpose. Charging_ Profile_ Purpose_ Code
    /// urn:x-oca:ocpp:uid:1:569231
    /// Specifies to purpose of the charging profiles that will be cleared, if they meet the other criteria in the request.
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
    /// A ChargingProfile consists of a ChargingSchedule, describing the amount of power or current that can be delivered per time interval.
    /// </summary>
    
    public partial class ClearChargingProfileType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Identified_ Object. MRID. Numeric_ Identifier
        /// urn:x-enexis:ecdm:uid:1:569198
        /// Specifies the id of the EVSE for which to clear charging profiles. An evseId of zero (0) specifies the charging profile for the overall Charging Station. Absence of this parameter means the clearing applies to all charging profiles that match the other criteria in the request.
        /// 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("evseId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int EvseId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("chargingProfilePurpose", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChargingProfilePurposeEnumType ChargingProfilePurpose { get; set; }
    
        /// <summary>Charging_ Profile. Stack_ Level. Counter
        /// urn:x-oca:ocpp:uid:1:569230
        /// Specifies the stackLevel for which charging profiles will be cleared, if they meet the other criteria in the request.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("stackLevel", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int StackLevel { get; set; }
    
    
    }
    
    
    public partial class Anonymous 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>The Id of the charging profile to clear.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("chargingProfileId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ChargingProfileId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("chargingProfileCriteria", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ClearChargingProfileType ChargingProfileCriteria { get; set; }
    
    
    }
}