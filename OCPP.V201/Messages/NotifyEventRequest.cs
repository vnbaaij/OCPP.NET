using OCPP.Core;

namespace OCPP.V201
{
    public partial class NotifyEventRequest : RequestBase<NotifyEventRequest>    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }


        /// <summary>Timestamp of the moment this message was generated at the Charging Station.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("generatedAt", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset GeneratedAt { get; set; }

        /// <summary>“to be continued” indicator. Indicates whether another part of the report follows in an upcoming notifyEventRequest message. Default value when omitted is false.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("tbc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Tbc { get; set; } = false;

        /// <summary>Sequence number of this message. First message starts at 0.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("seqNo", Required = Newtonsoft.Json.Required.Always)]
        public int SeqNo { get; set; }

        //[Newtonsoft.Json.JsonProperty("eventData", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<EventData> EventData { get; set; } = new System.Collections.ObjectModel.Collection<EventData>();


    }
}