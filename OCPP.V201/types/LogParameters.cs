namespace OCPP
{
    /// <summary>Log
    /// urn:x-enexis:ecdm:uid:2:233373
    /// Generic class for the configuration of logging entries.
    /// </summary>

    public partial class LogParameters 
    {
        /// <summary>Log. Remote_ Location. URI
        /// urn:x-enexis:ecdm:uid:1:569484
        /// The URL of the location at the remote system where the log should be stored.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("remoteLocation", Required = Newtonsoft.Json.Required.Always)]
        public string RemoteLocation { get; set; }
    
        /// <summary>Log. Oldest_ Timestamp. Date_ Time
        /// urn:x-enexis:ecdm:uid:1:569477
        /// This contains the date and time of the oldest logging information to include in the diagnostics.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("oldestTimestamp", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset OldestTimestamp { get; set; }
    
        /// <summary>Log. Latest_ Timestamp. Date_ Time
        /// urn:x-enexis:ecdm:uid:1:569482
        /// This contains the date and time of the latest logging information to include in the diagnostics.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("latestTimestamp", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset LatestTimestamp { get; set; }
    }
}