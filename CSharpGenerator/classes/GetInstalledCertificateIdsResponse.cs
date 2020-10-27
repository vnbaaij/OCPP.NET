





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
    
    /// <summary>Indicates the type of the requested certificate(s).
    /// </summary>
    
    public enum GetCertificateIdUseEnumType
    {
        
        V2GRootCertificate = 0,
    
        
        MORootCertificate = 1,
    
        
        CSMSRootCertificate = 2,
    
        
        V2GCertificateChain = 3,
    
        
        ManufacturerRootCertificate = 4,
    
    }
    
    /// <summary>Charging Station indicates if it can process the request.
    /// </summary>
    
    public enum GetInstalledCertificateStatusEnumType
    {
        
        Accepted = 0,
    
        
        NotFound = 1,
    
    }
    
    /// <summary>Used algorithms for the hashes provided.
    /// </summary>
    
    public enum HashAlgorithmEnumType
    {
        
        SHA256 = 0,
    
        
        SHA384 = 1,
    
        
        SHA512 = 2,
    
    }
    
    
    public partial class CertificateHashDataChainType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("certificateHashData", Required = Newtonsoft.Json.Required.Always)]
        public CertificateHashDataType CertificateHashData { get; set; } = new CertificateHashDataType();
    
        //[Newtonsoft.Json.JsonProperty("certificateType", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GetCertificateIdUseEnumType CertificateType { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("childCertificateHashData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<CertificateHashDataType> ChildCertificateHashData { get; set; }
    
    
    }
    
    
    public partial class CertificateHashDataType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("hashAlgorithm", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HashAlgorithmEnumType HashAlgorithm { get; set; }
    
        /// <summary>Hashed value of the Issuer DN (Distinguished Name).
        /// 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("issuerNameHash", Required = Newtonsoft.Json.Required.Always)]
        public string IssuerNameHash { get; set; }
    
        /// <summary>Hashed value of the issuers public key
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("issuerKeyHash", Required = Newtonsoft.Json.Required.Always)]
        public string IssuerKeyHash { get; set; }
    
        /// <summary>The serial number of the certificate.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("serialNumber", Required = Newtonsoft.Json.Required.Always)]
        public string SerialNumber { get; set; }
    
    
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
        public GetInstalledCertificateStatusEnumType Status { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("statusInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public StatusInfoType StatusInfo { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("certificateHashDataChain", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<CertificateHashDataChainType> CertificateHashDataChain { get; set; }
    
    
    }
}