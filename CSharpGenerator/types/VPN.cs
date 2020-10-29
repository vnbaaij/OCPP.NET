namespace OCPP
{
    /// <summary>VPN
    /// urn:x-oca:ocpp:uid:2:233268
    /// VPN Configuration settings
    /// </summary>

    public partial class VPN 
    {
        /// <summary>VPN. Server. URI
        /// urn:x-oca:ocpp:uid:1:569272
        /// VPN Server Address
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("server", Required = Newtonsoft.Json.Required.Always)]
        public string Server { get; set; }
    
        /// <summary>VPN. User. User_ Name
        /// urn:x-oca:ocpp:uid:1:569273
        /// VPN User
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("user", Required = Newtonsoft.Json.Required.Always)]
        public string User { get; set; }
    
        /// <summary>VPN. Group. Group_ Name
        /// urn:x-oca:ocpp:uid:1:569274
        /// VPN group.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("group", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Group { get; set; }
    
        /// <summary>VPN. Password. Password
        /// urn:x-oca:ocpp:uid:1:569275
        /// VPN Password.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("password", Required = Newtonsoft.Json.Required.Always)]
        public string Password { get; set; }
    
        /// <summary>VPN. Key. VPN_ Key
        /// urn:x-oca:ocpp:uid:1:569276
        /// VPN shared secret.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("key", Required = Newtonsoft.Json.Required.Always)]
        public string Key { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public VPN Type { get; set; }
    }
}