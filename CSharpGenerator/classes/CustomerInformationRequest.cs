





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
    
    /// <summary>Enumeration of possible idToken types.
    /// </summary>
    
    public enum IdTokenEnumType
    {
        
        Central = 0,
    
        
        EMAID = 1,
    
        
        ISO14443 = 2,
    
        
        ISO15693 = 3,
    
        
        KeyCode = 4,
    
        
        Local = 5,
    
        
        MacAddress = 6,
    
        
        NoAuthorization = 7,
    
    }
    
    /// <summary>Contains a case insensitive identifier to use for the authorization and the type of authorization to support multiple forms of identifiers.
    /// </summary>
    
    public partial class AdditionalInfoType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>This field specifies the additional IdToken.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("additionalIdToken", Required = Newtonsoft.Json.Required.Always)]
        public string AdditionalIdToken { get; set; }
    
        /// <summary>This defines the type of the additionalIdToken. This is a custom type, so the implementation needs to be agreed upon by all involved parties.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        public string Type { get; set; }
    
    
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
    
    /// <summary>Contains a case insensitive identifier to use for the authorization and the type of authorization to support multiple forms of identifiers.
    /// </summary>
    
    public partial class IdTokenType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("additionalInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AdditionalInfoType> AdditionalInfo { get; set; }
    
        /// <summary>IdToken is case insensitive. Might hold the hidden id of an RFID tag, but can for example also contain a UUID.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("idToken", Required = Newtonsoft.Json.Required.Always)]
        public string IdToken { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public IdTokenEnumType Type { get; set; }
    
    
    }
    
    
    public partial class Anonymous 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("customerCertificate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CertificateHashDataType CustomerCertificate { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("idToken", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IdTokenType IdToken { get; set; }
    
        /// <summary>The Id of the request.
        /// 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("requestId", Required = Newtonsoft.Json.Required.Always)]
        public int RequestId { get; set; }
    
        /// <summary>Flag indicating whether the Charging Station should return NotifyCustomerInformationRequest messages containing information about the customer referred to.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("report", Required = Newtonsoft.Json.Required.Always)]
        public bool Report { get; set; }
    
        /// <summary>Flag indicating whether the Charging Station should clear all information about the customer referred to.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("clear", Required = Newtonsoft.Json.Required.Always)]
        public bool Clear { get; set; }
    
        /// <summary>A (e.g. vendor specific) identifier of the customer this request refers to. This field contains a custom identifier other than IdToken and Certificate.
        /// One of the possible identifiers (customerIdentifier, customerIdToken or customerCertificate) should be in the request message.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("customerIdentifier", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerIdentifier { get; set; }
    
    
    }
}