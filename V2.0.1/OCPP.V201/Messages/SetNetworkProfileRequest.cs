using OCPP.V201.Core;

namespace OCPP.V201
{
    public partial class SetNetworkProfileRequest : RequestBase<SetNetworkProfileRequest>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        /// <summary>Slot in which the configuration should be stored.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("configurationSlot", Required = Newtonsoft.Json.Required.Always)]
        public int ConfigurationSlot { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("connectionData", Required = Newtonsoft.Json.Required.Always)]
        public NetworkConnectionProfile ConnectionData { get; set; } = new NetworkConnectionProfile();
    }
}