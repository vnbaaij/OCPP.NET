





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
    
    
    public partial class Anonymous 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>(Part of) the requested data. No format specified in which the data is returned. Should be human readable.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
        public string Data { get; set; }
    
        /// <summary>“to be continued” indicator. Indicates whether another part of the monitoringData follows in an upcoming notifyMonitoringReportRequest message. Default value when omitted is false.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("tbc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Tbc { get; set; } = false;
    
        /// <summary>Sequence number of this message. First message starts at 0.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("seqNo", Required = Newtonsoft.Json.Required.Always)]
        public int SeqNo { get; set; }
    
        /// <summary> Timestamp of the moment this message was generated at the Charging Station.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("generatedAt", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset GeneratedAt { get; set; }
    
        /// <summary>The Id of the request.
        /// 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("requestId", Required = Newtonsoft.Json.Required.Always)]
        public int RequestId { get; set; }
    
    
    }
}