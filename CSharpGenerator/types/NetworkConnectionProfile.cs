namespace OCPP
{
    /// <summary>Communication_ Function
    /// urn:x-oca:ocpp:uid:2:233304
    /// The NetworkConnectionProfile defines the functional and technical parameters of a communication link.
    /// </summary>

    public partial class NetworkConnectionProfile 
    {
        
    
        //[Newtonsoft.Json.JsonProperty("apn", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public APN Apn { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("ocppVersion", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OCPPVersion OcppVersion { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("ocppTransport", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OCPPTransport OcppTransport { get; set; }
    
        /// <summary>Communication_ Function. OCPP_ Central_ System_ URL. URI
        /// urn:x-oca:ocpp:uid:1:569357
        /// URL of the CSMS(s) that this Charging Station  communicates with.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("ocppCsmsUrl", Required = Newtonsoft.Json.Required.Always)]
        public string OcppCsmsUrl { get; set; }
    
        /// <summary>Duration in seconds before a message send by the Charging Station via this network connection times-out.
        /// The best setting depends on the underlying network and response times of the CSMS.
        /// If you are looking for a some guideline: use 30 seconds as a starting point.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("messageTimeout", Required = Newtonsoft.Json.Required.Always)]
        public int MessageTimeout { get; set; }
    
        /// <summary>This field specifies the security profile used when connecting to the CSMS with this NetworkConnectionProfile.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("securityProfile", Required = Newtonsoft.Json.Required.Always)]
        public int SecurityProfile { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("ocppInterface", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OCPPInterface OcppInterface { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("vpn", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public VPN Vpn { get; set; }
    
    
    }
}