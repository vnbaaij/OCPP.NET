namespace OCPP.V201
{
    /// <summary>Message_ Info
    /// urn:x-enexis:ecdm:uid:2:233264
    /// Contains message details, for a message to be displayed on a Charging Station.
    /// </summary>

    public partial class MessageInfo 
    {
        //[Newtonsoft.Json.JsonProperty("display", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Component Display { get; set; }
    
        /// <summary>Identified_ Object. MRID. Numeric_ Identifier
        /// urn:x-enexis:ecdm:uid:1:569198
        /// Master resource identifier, unique within an exchange context. It is defined within the OCPP context as a positive Integer value (greater or equal to zero).
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public int Id { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("priority", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MessagePriority Priority { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MessageState State { get; set; }
    
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
        public MessageContent Message { get; set; } = new MessageContent();
    }
}