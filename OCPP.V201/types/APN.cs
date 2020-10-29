namespace OCPP
{
    /// <summary>APN
    /// urn:x-oca:ocpp:uid:2:233134
    /// Collection of configuration data needed to make a data-connection over a cellular network.
    /// 
    /// NOTE: When asking a GSM modem to dial in, it is possible to specify which mobile operator should be used. This can be done with the mobile country code (MCC) in combination with a mobile network code (MNC). Example: If your preferred network is Vodafone Netherlands, the MCC=204 and the MNC=04 which means the key PreferredNetwork = 20404 Some modems allows to specify a preferred network, which means, if this network is not available, a different network is used. If you specify UseOnlyPreferredNetwork and this network is not available, the modem will not dial in.
    /// </summary>

    public partial class APN 
    {
        /// <summary>APN. APN. URI
        /// urn:x-oca:ocpp:uid:1:568814
        /// The Access Point Name as an URL.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("apn", Required = Newtonsoft.Json.Required.Always)]
        public string Apn { get; set; }
    
        /// <summary>APN. APN. User_ Name
        /// urn:x-oca:ocpp:uid:1:568818
        /// APN username.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("apnUserName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApnUserName { get; set; }
    
        /// <summary>APN. APN. Password
        /// urn:x-oca:ocpp:uid:1:568819
        /// APN Password.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("apnPassword", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApnPassword { get; set; }
    
        /// <summary>APN. SIMPIN. PIN_ Code
        /// urn:x-oca:ocpp:uid:1:568821
        /// SIM card pin code.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("simPin", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int SimPin { get; set; }
    
        /// <summary>APN. Preferred_ Network. Mobile_ Network_ ID
        /// urn:x-oca:ocpp:uid:1:568822
        /// Preferred network, written as MCC and MNC concatenated. See note.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("preferredNetwork", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PreferredNetwork { get; set; }
    
        /// <summary>APN. Use_ Only_ Preferred_ Network. Indicator
        /// urn:x-oca:ocpp:uid:1:568824
        /// Default: false. Use only the preferred Network, do
        /// not dial in when not available. See Note.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("useOnlyPreferredNetwork", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool UseOnlyPreferredNetwork { get; set; } = false;
    
        //[Newtonsoft.Json.JsonProperty("apnAuthentication", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public APNAuthentication ApnAuthentication { get; set; }
    }
}