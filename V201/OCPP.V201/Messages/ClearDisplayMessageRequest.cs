using OCPP.V201.Core;

namespace OCPP.V201
{
    public partial class ClearDisplayMessageRequest : RequestBase<ClearDisplayMessageRequest>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        /// <summary>Id of the message that SHALL be removed from the Charging Station.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public int Id { get; set; }
    }
}