





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
    
    /// <summary>This contains the progress status of the firmware installation.
    /// </summary>
    
    public enum FirmwareStatusEnumType
    {
        
        Downloaded = 0,
    
        
        DownloadFailed = 1,
    
        
        Downloading = 2,
    
        
        DownloadScheduled = 3,
    
        
        DownloadPaused = 4,
    
        
        Idle = 5,
    
        
        InstallationFailed = 6,
    
        
        Installing = 7,
    
        
        Installed = 8,
    
        
        InstallRebooting = 9,
    
        
        InstallScheduled = 10,
    
        
        InstallVerificationFailed = 11,
    
        
        InvalidSignature = 12,
    
        
        SignatureVerified = 13,
    
    }
    
    
    public partial class Anonymous 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public FirmwareStatusEnumType Status { get; set; }
    
        /// <summary>The request id that was provided in the
        /// UpdateFirmwareRequest that started this firmware update.
        /// This field is mandatory, unless the message was triggered by a TriggerMessageRequest AND there is no firmware update ongoing.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("requestId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RequestId { get; set; }
    
    
    }
}