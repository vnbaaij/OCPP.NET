





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
    
    /// <summary>Defines whether certificate needs to be installed or updated.
    /// </summary>
    
    public enum CertificateActionEnumType
    {
        
        Install = 0,
    
        
        Update = 1,
    
    }
    
    
    public partial class Anonymous 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Schema version currently used for the 15118 session between EV and Charging Station. Needed for parsing of the EXI stream by the CSMS.
        /// 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("iso15118SchemaVersion", Required = Newtonsoft.Json.Required.Always)]
        public string Iso15118SchemaVersion { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("action", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CertificateActionEnumType Action { get; set; }
    
        /// <summary>Raw CertificateInstallationReq request from EV, Base64 encoded.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("exiRequest", Required = Newtonsoft.Json.Required.Always)]
        public string ExiRequest { get; set; }
    
    
    }
}