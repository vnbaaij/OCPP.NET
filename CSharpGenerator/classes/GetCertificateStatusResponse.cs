





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
    
    /// <summary>This indicates whether the charging station was able to retrieve the OCSP certificate status.
    /// </summary>
    
    public enum GetCertificateStatusEnumType
    {
        
        Accepted = 0,
    
        
        Failed = 1,
    
    }
    
    /// <summary>Element providing more information about the status.
    /// </summary>
    
    public partial class StatusInfoType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>A predefined code for the reason why the status is returned in this response. The string is case-insensitive.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("reasonCode", Required = Newtonsoft.Json.Required.Always)]
        public string ReasonCode { get; set; }
    
        /// <summary>Additional text to provide detailed information.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("additionalInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdditionalInfo { get; set; }
    
    
    }
    
    
    public partial class Anonymous 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GetCertificateStatusEnumType Status { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("statusInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public StatusInfoType StatusInfo { get; set; }
    
        /// <summary>OCSPResponse class as defined in &amp;lt;&amp;lt;ref-ocpp_security_24, IETF RFC 6960&amp;gt;&amp;gt;. DER encoded (as defined in &amp;lt;&amp;lt;ref-ocpp_security_24, IETF RFC 6960&amp;gt;&amp;gt;), and then base64 encoded. MAY only be omitted when status is not Accepted.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("ocspResult", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OcspResult { get; set; }
    
    
    }
}