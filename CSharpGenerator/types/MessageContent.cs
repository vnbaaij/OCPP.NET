namespace OCPP
{
    /// <summary>Message_ Content
    /// urn:x-enexis:ecdm:uid:2:234490
    /// Contains message details, for a message to be displayed on a Charging Station.
    /// 
    /// </summary>

    public partial class MessageContent 
    {
        
    
        //[Newtonsoft.Json.JsonProperty("format", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MessageFormat Format { get; set; }
    
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
}