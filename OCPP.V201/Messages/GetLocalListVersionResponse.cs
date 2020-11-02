namespace OCPP.V201
{
    public partial class GetLocalListVersionResponse
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        /// <summary>This contains the current version number of the local authorization list in the Charging Station.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("versionNumber", Required = Newtonsoft.Json.Required.Always)]
        public int VersionNumber { get; set; }
    }
}