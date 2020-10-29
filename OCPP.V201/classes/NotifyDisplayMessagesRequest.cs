namespace OCPP
{
    public partial class NotifyDisplayMessagesRequest
    {


        //[Newtonsoft.Json.JsonProperty("messageInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<MessageInfo> MessageInfo { get; set; }

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