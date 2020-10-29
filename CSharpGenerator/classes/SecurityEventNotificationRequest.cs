namespace OCPP
{public partial class SecurityEventNotificationRequest
    {
        /// <summary> of the security event. This value should be taken from the Security events list.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        public string Type { get; set; }
    
        /// <summary>Date and time at which the event occurred.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset Timestamp { get; set; }
    
        /// <summary>Additional information about the occurred security event.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("techInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TechInfo { get; set; }
    }
}