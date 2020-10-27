





namespace OCPP
{
    #pragma warning disable // Disable all warnings

    /// <summary>This class does not get 'AdditionalProperties = false' in the schema generation, so it can be extended with arbitrary JSON properties to allow adding custom data.</summary>
    
    public partial class CustomDataType 
    {
        //[Newtonsoft.Json.JsonProperty("vendorId", Required = Newtonsoft.Json.Required.Always)]
        public string VendorId { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        //[Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    /// <summary>This contains the type of log file that the Charging Station
    /// should send.
    /// </summary>
    
    public enum LogEnumType
    {
        
        DiagnosticsLog = 0,
    
        
        SecurityLog = 1,
    
    }
    
    /// <summary>Log
    /// urn:x-enexis:ecdm:uid:2:233373
    /// Generic class for the configuration of logging entries.
    /// </summary>
    
    public partial class LogParametersType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
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
    
    
    public partial class Anonymous 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("log", Required = Newtonsoft.Json.Required.Always)]
        public LogParametersType Log { get; set; } = new LogParametersType();
    
        //[Newtonsoft.Json.JsonProperty("logType", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public LogEnumType LogType { get; set; }
    
        /// <summary>The Id of this request
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("requestId", Required = Newtonsoft.Json.Required.Always)]
        public int RequestId { get; set; }
    
        /// <summary>This specifies how many times the Charging Station must try to upload the log before giving up. If this field is not present, it is left to Charging Station to decide how many times it wants to retry.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("retries", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Retries { get; set; }
    
        /// <summary>The interval in seconds after which a retry may be attempted. If this field is not present, it is left to Charging Station to decide how long to wait between attempts.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("retryInterval", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RetryInterval { get; set; }
    
    
    }
}