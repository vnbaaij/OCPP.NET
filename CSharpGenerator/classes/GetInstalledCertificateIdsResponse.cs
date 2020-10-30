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
    
    /// <summary>Indicates the type of the requested certificate(s).
    /// </summary>
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
    
    /// <summary>Charging Station indicates if it can process the request.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum GetInstalledCertificateStatusEnumType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Accepted")]
        Accepted = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"NotFound")]
        NotFound = 1,
    
    }
    
    /// <summary>Used algorithms for the hashes provided.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum HashAlgorithmEnumType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"SHA256")]
        SHA256 = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"SHA384")]
        SHA384 = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"SHA512")]
        SHA512 = 2,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class CertificateHashDataChainType 
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        [Newtonsoft.Json.JsonProperty("certificateHashData", Required = Newtonsoft.Json.Required.Always)]
        public CertificateHashDataType CertificateHashData { get; set; } = new CertificateHashDataType();
    
        [Newtonsoft.Json.JsonProperty("certificateType", Required = Newtonsoft.Json.Required.Always)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GetCertificateIdUseEnumType CertificateType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("childCertificateHashData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<CertificateHashDataType> ChildCertificateHashData { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class CertificateHashDataType 
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        [Newtonsoft.Json.JsonProperty("hashAlgorithm", Required = Newtonsoft.Json.Required.Always)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HashAlgorithmEnumType HashAlgorithm { get; set; }
    
        /// <summary>Hashed value of the Issuer DN (Distinguished Name).
        /// 
        /// </summary>
        [Newtonsoft.Json.JsonProperty("issuerNameHash", Required = Newtonsoft.Json.Required.Always)]
        public string IssuerNameHash { get; set; }
    
        /// <summary>Hashed value of the issuers public key
        /// </summary>
        [Newtonsoft.Json.JsonProperty("issuerKeyHash", Required = Newtonsoft.Json.Required.Always)]
        public string IssuerKeyHash { get; set; }
    
        /// <summary>The serial number of the certificate.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("serialNumber", Required = Newtonsoft.Json.Required.Always)]
        public string SerialNumber { get; set; }
    
    
    }
    
    /// <summary>Element providing more information about the status.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class StatusInfoType 
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>A predefined code for the reason why the status is returned in this response. The string is case-insensitive.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reasonCode", Required = Newtonsoft.Json.Required.Always)]
        public string ReasonCode { get; set; }
    
        /// <summary>Additional text to provide detailed information.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("additionalInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdditionalInfo { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Anonymous 
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GetInstalledCertificateStatusEnumType Status { get; set; }
    
        [Newtonsoft.Json.JsonProperty("statusInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public StatusInfoType StatusInfo { get; set; }
    
        [Newtonsoft.Json.JsonProperty("certificateHashDataChain", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<CertificateHashDataChainType> CertificateHashDataChain { get; set; }
    
    
    }
}