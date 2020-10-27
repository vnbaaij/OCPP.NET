





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
    
        //[Newtonsoft.Json.JsonProperty("idToken", Required = Newtonsoft.Json.Required.Always)]
        public IdTokenType IdToken { get; set; } = new IdTokenType();
    
        /// <summary>The X.509 certificated presented by EV and encoded in PEM format.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("certificate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Certificate { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("iso15118CertificateHashData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<OCSPRequestDataType> Iso15118CertificateHashData { get; set; }
    
    
    }
}