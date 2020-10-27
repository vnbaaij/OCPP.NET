





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
    
    /// <summary>Used algorithms for the hashes provided.
    /// </summary>
    
    public enum HashAlgorithmEnumType
    {
        
        SHA256 = 0,
    
        
        SHA384 = 1,
    
        
        SHA512 = 2,
    
    }
    
    
    public partial class OCSPRequestDataType 
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
    
        /// <summary>This contains the responder URL (Case insensitive). 
        /// 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("responderURL", Required = Newtonsoft.Json.Required.Always)]
        public string ResponderURL { get; set; }
    
    
    }
    
    
    public partial class Anonymous 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("ocspRequestData", Required = Newtonsoft.Json.Required.Always)]
        public OCSPRequestDataType OcspRequestData { get; set; } = new OCSPRequestDataType();
    
    
    }
}