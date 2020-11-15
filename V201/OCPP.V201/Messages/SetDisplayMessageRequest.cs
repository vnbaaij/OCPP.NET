using OCPP.V201.Core;

namespace OCPP.V201
{
    public partial class SetDisplayMessageRequest : RequestBase<SetDisplayMessageRequest>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        //[Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.Always)]
        public MessageInfo Message { get; set; } = new MessageInfo();
    }
}