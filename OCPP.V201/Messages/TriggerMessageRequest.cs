using OCPP.Core;

namespace OCPP.V201
{
    public partial class TriggerMessageRequest : RequestBase<TriggerMessageRequest>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        //[Newtonsoft.Json.JsonProperty("evse", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EVSE Evse { get; set; }

        //[Newtonsoft.Json.JsonProperty("requestedMessage", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MessageTrigger RequestedMessage { get; set; }
    }
}