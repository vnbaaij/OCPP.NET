namespace OCPP
{


    public partial class SetNetworkProfileRequest
    {
        
    
        /// <summary>Slot in which the configuration should be stored.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("configurationSlot", Required = Newtonsoft.Json.Required.Always)]
        public int ConfigurationSlot { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("connectionData", Required = Newtonsoft.Json.Required.Always)]
        public NetworkConnectionProfile ConnectionData { get; set; } = new NetworkConnectionProfile();
    
    
    }
}