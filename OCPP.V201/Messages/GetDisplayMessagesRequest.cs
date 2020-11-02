using OCPP.Core;

namespace OCPP.V201
{
    public partial class GetDisplayMessagesRequest : RequestBase<GetDisplayMessagesRequest>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        /// <summary>If provided the Charging Station shall return Display Messages of the given ids. This field SHALL NOT contain more ids than set in &amp;lt;&amp;lt;configkey-number-of-display-messages,NumberOfDisplayMessages.maxLimit&amp;gt;&amp;gt;
        /// 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<int> Id { get; set; }
    
        /// <summary>The Id of this request.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("requestId", Required = Newtonsoft.Json.Required.Always)]
        public int RequestId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("priority", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MessagePriority Priority { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MessageState State { get; set; }
    }
}