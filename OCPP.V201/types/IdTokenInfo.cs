namespace OCPP.V201
{
    /// <summary>
    /// Contains a case insensitive identifier to use for the authorization and the  of authorization to support multiple forms of identifiers.
    /// </summary>


    /// <summary>ID_ Token
    /// urn:x-oca:ocpp:uid:2:233247
    /// Contains status information about an identifier.
    /// It is advised to not stop charging for a token that expires during charging, as ExpiryDate is only used for caching purposes. If ExpiryDate is not given, the status has no end date.
    /// </summary>

    public partial class IdTokenInfo
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AuthorizationStatus Status { get; set; }

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
        public IdToken GroupIdToken { get; set; }

        /// <summary>ID_ Token. Language2. Language_ Code
        /// urn:x-oca:ocpp:uid:1:569375
        /// Second preferred user interface language of identifier user. Don’t use when language1 is omitted, has to be different from language1. Contains a language code as defined in &amp;lt;&amp;lt;ref-RFC5646,[RFC5646]&amp;gt;&amp;gt;.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("language2", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Language2 { get; set; }

        //[Newtonsoft.Json.JsonProperty("personalMessage", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public MessageContent PersonalMessage { get; set; }


    }
}