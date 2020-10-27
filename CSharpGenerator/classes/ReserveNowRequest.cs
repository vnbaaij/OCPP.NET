





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
    
    /// <summary>This field specifies the connector type.
    /// </summary>
    
    public enum ConnectorEnumType
    {
        
        CCCS1 = 0,
    
        
        CCCS2 = 1,
    
        
        CG105 = 2,
    
        
        CTesla = 3,
    
        
        CType1 = 4,
    
        
        CType2 = 5,
    
        
        S3091P16A = 6,
    
        
        S3091P32A = 7,
    
        
        S3093P16A = 8,
    
        
        S3093P32A = 9,
    
        
        SBS1361 = 10,
    
        
        SCEE77 = 11,
    
        
        SType2 = 12,
    
        
        SType3 = 13,
    
        
        Other1PhMax16A = 14,
    
        
        Other1PhOver16A = 15,
    
        
        Other3Ph = 16,
    
        
        Pan = 17,
    
        
        WInductive = 18,
    
        
        WResonant = 19,
    
        
        Undetermined = 20,
    
        
        Unknown = 21,
    
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
    
        /// <summary>Id of reservation.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public int Id { get; set; }
    
        /// <summary>Date and time at which the reservation expires.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("expiryDateTime", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset ExpiryDateTime { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("connectorType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ConnectorEnumType ConnectorType { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("idToken", Required = Newtonsoft.Json.Required.Always)]
        public IdTokenType IdToken { get; set; } = new IdTokenType();
    
        /// <summary>This contains ID of the evse to be reserved.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("evseId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int EvseId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("groupIdToken", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IdTokenType GroupIdToken { get; set; }
    
    
    }
}