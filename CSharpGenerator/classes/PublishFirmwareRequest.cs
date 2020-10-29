namespace OCPP
{public partial class PublishFirmwareRequest
    {
        
    
        /// <summary>This contains a string containing a URI pointing to a
        /// location from which to retrieve the firmware.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("location", Required = Newtonsoft.Json.Required.Always)]
        public string Location { get; set; }
    
        /// <summary>This specifies how many times Charging Station must try
        /// to download the firmware before giving up. If this field is not
        /// present, it is left to Charging Station to decide how many times it wants to retry.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("retries", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Retries { get; set; }
    
        /// <summary>The MD5 checksum over the entire firmware file as a hexadecimal string of length 32. 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("checksum", Required = Newtonsoft.Json.Required.Always)]
        public string Checksum { get; set; }
    
        /// <summary>The Id of the request.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("requestId", Required = Newtonsoft.Json.Required.Always)]
        public int RequestId { get; set; }
    
        /// <summary>The interval in seconds
        /// after which a retry may be
        /// attempted. If this field is not
        /// present, it is left to Charging
        /// Station to decide how long to wait
        /// between attempts.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("retryInterval", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RetryInterval { get; set; }
    
    
    }
}