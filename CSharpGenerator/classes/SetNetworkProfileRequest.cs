//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.2.2.0 (Newtonsoft.Json v9.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace OCPP.Generated
{
    #pragma warning disable // Disable all warnings

    /// <summary>This class does not get 'AdditionalProperties = false' in the schema generation, so it can be extended with arbitrary JSON properties to allow adding custom data.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class CustomDataType 
    {
        [Newtonsoft.Json.JsonProperty("vendorId", Required = Newtonsoft.Json.Required.Always)]
        public string VendorId { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    /// <summary>APN. APN_ Authentication. APN_ Authentication_ Code
    /// urn:x-oca:ocpp:uid:1:568828
    /// Authentication method.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum APNAuthenticationEnumType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"CHAP")]
        CHAP = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"NONE")]
        NONE = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PAP")]
        PAP = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"AUTO")]
        AUTO = 3,
    
    }
    
    /// <summary>Applicable Network Interface.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum OCPPInterfaceEnumType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Wired0")]
        Wired0 = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Wired1")]
        Wired1 = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Wired2")]
        Wired2 = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Wired3")]
        Wired3 = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Wireless0")]
        Wireless0 = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Wireless1")]
        Wireless1 = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Wireless2")]
        Wireless2 = 6,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Wireless3")]
        Wireless3 = 7,
    
    }
    
    /// <summary>Communication_ Function. OCPP_ Transport. OCPP_ Transport_ Code
    /// urn:x-oca:ocpp:uid:1:569356
    /// Defines the transport protocol (e.g. SOAP or JSON). Note: SOAP is not supported in OCPP 2.0, but is supported by other versions of OCPP.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum OCPPTransportEnumType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"JSON")]
        JSON = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"SOAP")]
        SOAP = 1,
    
    }
    
    /// <summary>Communication_ Function. OCPP_ Version. OCPP_ Version_ Code
    /// urn:x-oca:ocpp:uid:1:569355
    /// Defines the OCPP version used for this communication function.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum OCPPVersionEnumType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"OCPP12")]
        OCPP12 = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"OCPP15")]
        OCPP15 = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"OCPP16")]
        OCPP16 = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"OCPP20")]
        OCPP20 = 3,
    
    }
    
    /// <summary>VPN. Type. VPN_ Code
    /// urn:x-oca:ocpp:uid:1:569277
    /// Type of VPN
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum VPNEnumType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"IKEv2")]
        IKEv2 = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"IPSec")]
        IPSec = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"L2TP")]
        L2TP = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PPTP")]
        PPTP = 3,
    
    }
    
    /// <summary>APN
    /// urn:x-oca:ocpp:uid:2:233134
    /// Collection of configuration data needed to make a data-connection over a cellular network.
    /// 
    /// NOTE: When asking a GSM modem to dial in, it is possible to specify which mobile operator should be used. This can be done with the mobile country code (MCC) in combination with a mobile network code (MNC). Example: If your preferred network is Vodafone Netherlands, the MCC=204 and the MNC=04 which means the key PreferredNetwork = 20404 Some modems allows to specify a preferred network, which means, if this network is not available, a different network is used. If you specify UseOnlyPreferredNetwork and this network is not available, the modem will not dial in.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class APNType 
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>APN. APN. URI
        /// urn:x-oca:ocpp:uid:1:568814
        /// The Access Point Name as an URL.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apn", Required = Newtonsoft.Json.Required.Always)]
        public string Apn { get; set; }
    
        /// <summary>APN. APN. User_ Name
        /// urn:x-oca:ocpp:uid:1:568818
        /// APN username.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apnUserName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApnUserName { get; set; }
    
        /// <summary>APN. APN. Password
        /// urn:x-oca:ocpp:uid:1:568819
        /// APN Password.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apnPassword", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ApnPassword { get; set; }
    
        /// <summary>APN. SIMPIN. PIN_ Code
        /// urn:x-oca:ocpp:uid:1:568821
        /// SIM card pin code.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("simPin", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int SimPin { get; set; }
    
        /// <summary>APN. Preferred_ Network. Mobile_ Network_ ID
        /// urn:x-oca:ocpp:uid:1:568822
        /// Preferred network, written as MCC and MNC concatenated. See note.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("preferredNetwork", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PreferredNetwork { get; set; }
    
        /// <summary>APN. Use_ Only_ Preferred_ Network. Indicator
        /// urn:x-oca:ocpp:uid:1:568824
        /// Default: false. Use only the preferred Network, do
        /// not dial in when not available. See Note.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("useOnlyPreferredNetwork", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool UseOnlyPreferredNetwork { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("apnAuthentication", Required = Newtonsoft.Json.Required.Always)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public APNAuthenticationEnumType ApnAuthentication { get; set; }
    
    
    }
    
    /// <summary>Communication_ Function
    /// urn:x-oca:ocpp:uid:2:233304
    /// The NetworkConnectionProfile defines the functional and technical parameters of a communication link.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class NetworkConnectionProfileType 
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        [Newtonsoft.Json.JsonProperty("apn", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public APNType Apn { get; set; }
    
        [Newtonsoft.Json.JsonProperty("ocppVersion", Required = Newtonsoft.Json.Required.Always)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OCPPVersionEnumType OcppVersion { get; set; }
    
        [Newtonsoft.Json.JsonProperty("ocppTransport", Required = Newtonsoft.Json.Required.Always)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OCPPTransportEnumType OcppTransport { get; set; }
    
        /// <summary>Communication_ Function. OCPP_ Central_ System_ URL. URI
        /// urn:x-oca:ocpp:uid:1:569357
        /// URL of the CSMS(s) that this Charging Station  communicates with.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ocppCsmsUrl", Required = Newtonsoft.Json.Required.Always)]
        public string OcppCsmsUrl { get; set; }
    
        /// <summary>Duration in seconds before a message send by the Charging Station via this network connection times-out.
        /// The best setting depends on the underlying network and response times of the CSMS.
        /// If you are looking for a some guideline: use 30 seconds as a starting point.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("messageTimeout", Required = Newtonsoft.Json.Required.Always)]
        public int MessageTimeout { get; set; }
    
        /// <summary>This field specifies the security profile used when connecting to the CSMS with this NetworkConnectionProfile.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("securityProfile", Required = Newtonsoft.Json.Required.Always)]
        public int SecurityProfile { get; set; }
    
        [Newtonsoft.Json.JsonProperty("ocppInterface", Required = Newtonsoft.Json.Required.Always)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OCPPInterfaceEnumType OcppInterface { get; set; }
    
        [Newtonsoft.Json.JsonProperty("vpn", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public VPNType Vpn { get; set; }
    
    
    }
    
    /// <summary>VPN
    /// urn:x-oca:ocpp:uid:2:233268
    /// VPN Configuration settings
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class VPNType 
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>VPN. Server. URI
        /// urn:x-oca:ocpp:uid:1:569272
        /// VPN Server Address
        /// </summary>
        [Newtonsoft.Json.JsonProperty("server", Required = Newtonsoft.Json.Required.Always)]
        public string Server { get; set; }
    
        /// <summary>VPN. User. User_ Name
        /// urn:x-oca:ocpp:uid:1:569273
        /// VPN User
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user", Required = Newtonsoft.Json.Required.Always)]
        public string User { get; set; }
    
        /// <summary>VPN. Group. Group_ Name
        /// urn:x-oca:ocpp:uid:1:569274
        /// VPN group.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Group { get; set; }
    
        /// <summary>VPN. Password. Password
        /// urn:x-oca:ocpp:uid:1:569275
        /// VPN Password.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("password", Required = Newtonsoft.Json.Required.Always)]
        public string Password { get; set; }
    
        /// <summary>VPN. Key. VPN_ Key
        /// urn:x-oca:ocpp:uid:1:569276
        /// VPN shared secret.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("key", Required = Newtonsoft.Json.Required.Always)]
        public string Key { get; set; }
    
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public VPNEnumType Type { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Anonymous 
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Slot in which the configuration should be stored.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("configurationSlot", Required = Newtonsoft.Json.Required.Always)]
        public int ConfigurationSlot { get; set; }
    
        [Newtonsoft.Json.JsonProperty("connectionData", Required = Newtonsoft.Json.Required.Always)]
        public NetworkConnectionProfileType ConnectionData { get; set; } = new NetworkConnectionProfileType();
    
    
    }
}