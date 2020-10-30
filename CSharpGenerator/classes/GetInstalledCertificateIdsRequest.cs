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
    public enum GetCertificateIdUseEnumType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"V2GRootCertificate")]
        V2GRootCertificate = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"MORootCertificate")]
        MORootCertificate = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"CSMSRootCertificate")]
        CSMSRootCertificate = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"V2GCertificateChain")]
        V2GCertificateChain = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ManufacturerRootCertificate")]
        ManufacturerRootCertificate = 4,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Anonymous 
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Indicates the type of certificates requested. When omitted, all certificate types are requested.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("certificateType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public System.Collections.Generic.ICollection<GetCertificateIdUseEnumType> CertificateType { get; set; }
    
    
    }
}