





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
    
    /// <summary>Message_ Info. Priority. Message_ Priority_ Code
    /// urn:x-enexis:ecdm:uid:1:569253
    /// With what priority should this message be shown
    /// </summary>
    
    public enum MessagePriorityEnumType
    {
        
        AlwaysFront = 0,
    
        
        InFront = 1,
    
        
        NormalCycle = 2,
    
    }
    
    /// <summary>Message_ Info. State. Message_ State_ Code
    /// urn:x-enexis:ecdm:uid:1:569254
    /// During what state should this message be shown. When omitted this message should be shown in any state of the Charging Station.
    /// </summary>
    
    public enum MessageStateEnumType
    {
        
        Charging = 0,
    
        
        Faulted = 1,
    
        
        Idle = 2,
    
        
        Unavailable = 3,
    
    }
    
    /// <summary>A physical or logical component
    /// </summary>
    
    public partial class ComponentType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("evse", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EVSEType Evse { get; set; }
    
        /// <summary>Name of the component. Name should be taken from the list of standardized component names whenever possible. Case Insensitive. strongly advised to use Camel Case.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        public string Name { get; set; }
    
        /// <summary>Name of instance in case the component exists as multiple instances. Case Insensitive. strongly advised to use Camel Case.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("instance", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Instance { get; set; }
    
    
    }
    
    /// <summary>EVSE
    /// urn:x-oca:ocpp:uid:2:233123
    /// Electric Vehicle Supply Equipment
    /// </summary>
    
    public partial class EVSEType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Identified_ Object. MRID. Numeric_ Identifier
        /// urn:x-enexis:ecdm:uid:1:569198
        /// EVSE Identifier. This contains a number (&amp;gt; 0) designating an EVSE of the Charging Station.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public int Id { get; set; }
    
        /// <summary>An id to designate a specific connector (on an EVSE) by connector index number.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("connectorId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ConnectorId { get; set; }
    
    
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
    
    /// <summary>Message_ Info
    /// urn:x-enexis:ecdm:uid:2:233264
    /// Contains message details, for a message to be displayed on a Charging Station.
    /// </summary>
    
    public partial class MessageInfoType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("display", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ComponentType Display { get; set; }
    
        /// <summary>Identified_ Object. MRID. Numeric_ Identifier
        /// urn:x-enexis:ecdm:uid:1:569198
        /// Master resource identifier, unique within an exchange context. It is defined within the OCPP context as a positive Integer value (greater or equal to zero).
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public int Id { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("priority", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MessagePriorityEnumType Priority { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MessageStateEnumType State { get; set; }
    
        /// <summary>Message_ Info. Start. Date_ Time
        /// urn:x-enexis:ecdm:uid:1:569256
        /// From what date-time should this message be shown. If omitted: directly.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("startDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset StartDateTime { get; set; }
    
        /// <summary>Message_ Info. End. Date_ Time
        /// urn:x-enexis:ecdm:uid:1:569257
        /// Until what date-time should this message be shown, after this date/time this message SHALL be removed.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("endDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset EndDateTime { get; set; }
    
        /// <summary>During which transaction shall this message be shown.
        /// Message SHALL be removed by the Charging Station after transaction has
        /// ended.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("transactionId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TransactionId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Always)]
        public MessageContentType Message { get; set; } = new MessageContentType();
    
    
    }
    
    
    public partial class Anonymous 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("messageInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<MessageInfoType> MessageInfo { get; set; }
    
        /// <summary>The id of the &amp;lt;&amp;lt;getdisplaymessagesrequest,GetDisplayMessagesRequest&amp;gt;&amp;gt; that requested this message.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("requestId", Required = Newtonsoft.Json.Required.Always)]
        public int RequestId { get; set; }
    
        /// <summary>"to be continued" indicator. Indicates whether another part of the report follows in an upcoming NotifyDisplayMessagesRequest message. Default value when omitted is false.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("tbc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Tbc { get; set; } = false;
    
    
    }
}