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
    
    /// <summary>This contains the progress status of the publishfirmware
    /// installation.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum PublishFirmwareStatusEnumType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Idle")]
        Idle = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"DownloadScheduled")]
        DownloadScheduled = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Downloading")]
        Downloading = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Downloaded")]
        Downloaded = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Published")]
        Published = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"DownloadFailed")]
        DownloadFailed = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = @"DownloadPaused")]
        DownloadPaused = 6,
    
        [System.Runtime.Serialization.EnumMember(Value = @"InvalidChecksum")]
        InvalidChecksum = 7,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ChecksumVerified")]
        ChecksumVerified = 8,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PublishFailed")]
        PublishFailed = 9,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Anonymous 
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PublishFirmwareStatusEnumType Status { get; set; }
    
        /// <summary>Required if status is Published. Can be multiple URI’s, if the Local Controller supports e.g. HTTP, HTTPS, and FTP.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> Location { get; set; }
    
        /// <summary>The request id that was
        /// provided in the
        /// PublishFirmwareRequest which
        /// triggered this action.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("requestId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RequestId { get; set; }
    
    
    }
}