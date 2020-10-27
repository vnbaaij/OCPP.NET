





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
    
    
    public partial class Anonymous 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>The Charging Station SHALL only report events with a severity number lower than or equal to this severity.
        /// The severity range is 0-9, with 0 as the highest and 9 as the lowest severity level.
        /// 
        /// The severity levels have the following meaning: +
        /// *0-Danger* +
        /// Indicates lives are potentially in danger. Urgent attention is needed and action should be taken immediately. +
        /// *1-Hardware Failure* +
        /// Indicates that the Charging Station is unable to continue regular operations due to Hardware issues. Action is required. +
        /// *2-System Failure* +
        /// Indicates that the Charging Station is unable to continue regular operations due to software or minor hardware issues. Action is required. +
        /// *3-Critical* +
        /// Indicates a critical error. Action is required. +
        /// *4-Error* +
        /// Indicates a non-urgent error. Action is required. +
        /// *5-Alert* +
        /// Indicates an alert event. Default severity for any type of monitoring event.  +
        /// *6-Warning* +
        /// Indicates a warning event. Action may be required. +
        /// *7-Notice* +
        /// Indicates an unusual event. No immediate action is required. +
        /// *8-Informational* +
        /// Indicates a regular operational event. May be used for reporting, measuring throughput, etc. No action is required. +
        /// *9-Debug* +
        /// Indicates information useful to developers for debugging, not useful during operations.
        /// 
        /// 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("severity", Required = Newtonsoft.Json.Required.Always)]
        public int Severity { get; set; }
    
    
    }
}