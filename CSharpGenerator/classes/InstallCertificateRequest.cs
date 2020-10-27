





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
    
    /// <summary>Indicates the certificate type that is sent.
    /// </summary>
    
    public enum InstallCertificateUseEnumType
    {
        
        V2GRootCertificate = 0,
    
        
        MORootCertificate = 1,
    
        
        CSMSRootCertificate = 2,
    
        
        ManufacturerRootCertificate = 3,
    
    }
    
    
    public partial class Anonymous 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("certificateType", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public InstallCertificateUseEnumType CertificateType { get; set; }
    
        /// <summary>A PEM encoded X.509 certificate.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("certificate", Required = Newtonsoft.Json.Required.Always)]
        public string Certificate { get; set; }
    
    
    }
}