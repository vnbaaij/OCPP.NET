





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
    
    /// <summary>Firmware
    /// urn:x-enexis:ecdm:uid:2:233291
    /// Represents a copy of the firmware that can be loaded/updated on the Charging Station.
    /// </summary>
    
    public partial class FirmwareType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Firmware. Location. URI
        /// urn:x-enexis:ecdm:uid:1:569460
        /// URI defining the origin of the firmware.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("location", Required = Newtonsoft.Json.Required.Always)]
        public string Location { get; set; }
    
        /// <summary>Firmware. Retrieve. Date_ Time
        /// urn:x-enexis:ecdm:uid:1:569461
        /// Date and time at which the firmware shall be retrieved.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("retrieveDateTime", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset RetrieveDateTime { get; set; }
    
        /// <summary>Firmware. Install. Date_ Time
        /// urn:x-enexis:ecdm:uid:1:569462
        /// Date and time at which the firmware shall be installed.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("installDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset InstallDateTime { get; set; }
    
        /// <summary>Certificate with which the firmware was signed.
        /// PEM encoded X.509 certificate.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("signingCertificate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SigningCertificate { get; set; }
    
        /// <summary>Firmware. Signature. Signature
        /// urn:x-enexis:ecdm:uid:1:569464
        /// Base64 encoded firmware signature.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("signature", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Signature { get; set; }
    
    
    }
    
    
    public partial class Anonymous 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>This specifies how many times Charging Station must try to download the firmware before giving up. If this field is not present, it is left to Charging Station to decide how many times it wants to retry.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("retries", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Retries { get; set; }
    
        /// <summary>The interval in seconds after which a retry may be attempted. If this field is not present, it is left to Charging Station to decide how long to wait between attempts.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("retryInterval", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RetryInterval { get; set; }
    
        /// <summary>The Id of this request
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("requestId", Required = Newtonsoft.Json.Required.Always)]
        public int RequestId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("firmware", Required = Newtonsoft.Json.Required.Always)]
        public FirmwareType Firmware { get; set; } = new FirmwareType();
    
    
    }
}