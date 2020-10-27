





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
    
    /// <summary>ID_ Token. Status. Authorization_ Status
    /// urn:x-oca:ocpp:uid:1:569372
    /// Current status of the ID Token.
    /// </summary>
    
    public enum AuthorizationStatusEnumType
    {
        
        Accepted = 0,
    
        
        Blocked = 1,
    
        
        ConcurrentTx = 2,
    
        
        Expired = 3,
    
        
        Invalid = 4,
    
        
        NoCredit = 5,
    
        
        NotAllowedTypeEVSE = 6,
    
        
        NotAtThisLocation = 7,
    
        
        NotAtThisTime = 8,
    
        
        Unknown = 9,
    
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
    
    /// <summary>Message_ Content. Format. Message_ Format_ Code
    /// urn:x-enexis:ecdm:uid:1:570848
    /// Format of the message.
    /// </summary>
    
    public enum MessageFormatEnumType
    {
        
        ASCII = 0,
    
        
        HTML = 1,
    
        
        URI = 2,
    
        
        UTF8 = 3,
    
    }
    
    /// <summary>This contains the type of update (full or differential) of this request.
    /// </summary>
    
    public enum UpdateEnumType
    {
        
        Differential = 0,
    
        
        Full = 1,
    
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
    
    /// <summary>Contains the identifier to use for authorization.
    /// </summary>
    
    public partial class AuthorizationData 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("idToken", Required = Newtonsoft.Json.Required.Always)]
        public IdTokenType IdToken { get; set; } = new IdTokenType();
    
        //[Newtonsoft.Json.JsonProperty("idTokenInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IdTokenInfoType IdTokenInfo { get; set; }
    
    
    }
    
    /// <summary>ID_ Token
    /// urn:x-oca:ocpp:uid:2:233247
    /// Contains status information about an identifier.
    /// It is advised to not stop charging for a token that expires during charging, as ExpiryDate is only used for caching purposes. If ExpiryDate is not given, the status has no end date.
    /// </summary>
    
    public partial class IdTokenInfoType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AuthorizationStatusEnumType Status { get; set; }
    
        /// <summary>ID_ Token. Expiry. Date_ Time
        /// urn:x-oca:ocpp:uid:1:569373
        /// Date and Time after which the token must be considered invalid.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("cacheExpiryDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CacheExpiryDateTime { get; set; }
    
        /// <summary>Priority from a business point of view. Default priority is 0, The range is from -9 to 9. Higher values indicate a higher priority. The chargingPriority in &amp;lt;&amp;lt;transactioneventresponse,TransactionEventResponse&amp;gt;&amp;gt; overrules this one. 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("chargingPriority", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ChargingPriority { get; set; }
    
        /// <summary>ID_ Token. Language1. Language_ Code
        /// urn:x-oca:ocpp:uid:1:569374
        /// Preferred user interface language of identifier user. Contains a language code as defined in &amp;lt;&amp;lt;ref-RFC5646,[RFC5646]&amp;gt;&amp;gt;.
        /// 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("language1", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Language1 { get; set; }
    
        /// <summary>Only used when the IdToken is only valid for one or more specific EVSEs, not for the entire Charging Station.
        /// 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("evseId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<int> EvseId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("groupIdToken", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IdTokenType GroupIdToken { get; set; }
    
        /// <summary>ID_ Token. Language2. Language_ Code
        /// urn:x-oca:ocpp:uid:1:569375
        /// Second preferred user interface language of identifier user. Don’t use when language1 is omitted, has to be different from language1. Contains a language code as defined in &amp;lt;&amp;lt;ref-RFC5646,[RFC5646]&amp;gt;&amp;gt;.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("language2", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Language2 { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("personalMessage", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public MessageContentType PersonalMessage { get; set; }
    
    
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
    
    /// <summary>Message_ Content
    /// urn:x-enexis:ecdm:uid:2:234490
    /// Contains message details, for a message to be displayed on a Charging Station.
    /// 
    /// </summary>
    
    public partial class MessageContentType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("format", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MessageFormatEnumType Format { get; set; }
    
        /// <summary>Message_ Content. Language. Language_ Code
        /// urn:x-enexis:ecdm:uid:1:570849
        /// Message language identifier. Contains a language code as defined in &amp;lt;&amp;lt;ref-RFC5646,[RFC5646]&amp;gt;&amp;gt;.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("language", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Language { get; set; }
    
        /// <summary>Message_ Content. Content. Message
        /// urn:x-enexis:ecdm:uid:1:570852
        /// Message contents.
        /// 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("content", Required = Newtonsoft.Json.Required.Always)]
        public string Content { get; set; }
    
    
    }
    
    
    public partial class Anonymous 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("localAuthorizationList", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AuthorizationData> LocalAuthorizationList { get; set; }
    
        /// <summary>In case of a full update this is the version number of the full list. In case of a differential update it is the version number of the list after the update has been applied.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("versionNumber", Required = Newtonsoft.Json.Required.Always)]
        public int VersionNumber { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("updateType", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public UpdateEnumType UpdateType { get; set; }
    
    
    }
}