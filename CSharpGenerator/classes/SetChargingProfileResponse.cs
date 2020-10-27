





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
    
    /// <summary>Returns whether the Charging Station has been able to process the message successfully. This does not guarantee the schedule will be followed to the letter. There might be other constraints the Charging Station may need to take into account.
    /// </summary>
    
    public enum ChargingProfileStatusEnumType
    {
        
        Accepted = 0,
    
        
        Rejected = 1,
    
    }
    
    /// <summary>Element providing more information about the status.
    /// </summary>
    
    public partial class StatusInfoType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>A predefined code for the reason why the status is returned in this response. The string is case-insensitive.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("reasonCode", Required = Newtonsoft.Json.Required.Always)]
        public string ReasonCode { get; set; }
    
        /// <summary>Additional text to provide detailed information.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("additionalInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdditionalInfo { get; set; }
    
    
    }
    
    
    public partial class Anonymous 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChargingProfileStatusEnumType Status { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("statusInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public StatusInfoType StatusInfo { get; set; }
    
    
    }
}