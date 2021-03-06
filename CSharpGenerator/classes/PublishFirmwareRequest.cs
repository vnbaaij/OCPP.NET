//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.2.2.0 (Newtonsoft.Json v9.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace OCPP.Generated
{
    #pragma warning disable // Disable all warnings

    /// <summary>This class does not get 'AdditionalProperties = false' in the schema generation, so it can be extended with arbitrary JSON properties to allow adding custom data.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class CustomDataType 
    {
        [Newtonsoft.Json.JsonProperty("vendorId", Required = Newtonsoft.Json.Required.Always)]
        public string VendorId { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Anonymous 
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>This contains a string containing a URI pointing to a
        /// location from which to retrieve the firmware.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location", Required = Newtonsoft.Json.Required.Always)]
        public string Location { get; set; }
    
        /// <summary>This specifies how many times Charging Station must try
        /// to download the firmware before giving up. If this field is not
        /// present, it is left to Charging Station to decide how many times it wants to retry.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("retries", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Retries { get; set; }
    
        /// <summary>The MD5 checksum over the entire firmware file as a hexadecimal string of length 32. 
        /// </summary>
        [Newtonsoft.Json.JsonProperty("checksum", Required = Newtonsoft.Json.Required.Always)]
        public string Checksum { get; set; }
    
        /// <summary>The Id of the request.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("requestId", Required = Newtonsoft.Json.Required.Always)]
        public int RequestId { get; set; }
    
        /// <summary>The interval in seconds
        /// after which a retry may be
        /// attempted. If this field is not
        /// present, it is left to Charging
        /// Station to decide how long to wait
        /// between attempts.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("retryInterval", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RetryInterval { get; set; }
    
    
    }
}