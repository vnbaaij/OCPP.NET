namespace OCPP
{
    /// <summary>Relative_ Timer_ Interval
    /// urn:x-oca:ocpp:uid:2:233270
    /// </summary>

    public partial class RelativeTimeInterval 
    {
        
    
        /// <summary>Relative_ Timer_ Interval. Start. Elapsed_ Time
        /// urn:x-oca:ocpp:uid:1:569279
        /// Start of the interval, in seconds from NOW.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.Always)]
        public int Start { get; set; }
    
        /// <summary>Relative_ Timer_ Interval. Duration. Elapsed_ Time
        /// urn:x-oca:ocpp:uid:1:569280
        /// Duration of the interval, in seconds.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("duration", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Duration { get; set; }
    
    
    }
}