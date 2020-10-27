





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
    
    /// <summary>This contains the reason for sending this message to the CSMS.
    /// </summary>
    
    public enum BootReasonEnumType
    {
        
        ApplicationReset = 0,
    
        
        FirmwareUpdate = 1,
    
        
        LocalReset = 2,
    
        
        PowerUp = 3,
    
        
        RemoteReset = 4,
    
        
        ScheduledReset = 5,
    
        
        Triggered = 6,
    
        
        Unknown = 7,
    
        
        Watchdog = 8,
    
    }
    
    /// <summary>Charge_ Point
    /// urn:x-oca:ocpp:uid:2:233122
    /// The physical system where an Electrical Vehicle (EV) can be charged.
    /// </summary>
    
    public partial class ChargingStationType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Device. Serial_ Number. Serial_ Number
        /// urn:x-oca:ocpp:uid:1:569324
        /// Vendor-specific device identifier.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("serialNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SerialNumber { get; set; }
    
        /// <summary>Device. Model. CI20_ Text
        /// urn:x-oca:ocpp:uid:1:569325
        /// Defines the model of the device.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("model", Required = Newtonsoft.Json.Required.Always)]
        public string Model { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("modem", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ModemType Modem { get; set; }
    
        /// <summary>Identifies the vendor (not necessarily in a unique manner).
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("vendorName", Required = Newtonsoft.Json.Required.Always)]
        public string VendorName { get; set; }
    
        /// <summary>This contains the firmware version of the Charging Station.
        /// 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("firmwareVersion", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirmwareVersion { get; set; }
    
    
    }
    
    /// <summary>Wireless_ Communication_ Module
    /// urn:x-oca:ocpp:uid:2:233306
    /// Defines parameters required for initiating and maintaining wireless communication with other devices.
    /// </summary>
    
    public partial class ModemType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Wireless_ Communication_ Module. ICCID. CI20_ Text
        /// urn:x-oca:ocpp:uid:1:569327
        /// This contains the ICCID of the modem’s SIM card.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("iccid", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Iccid { get; set; }
    
        /// <summary>Wireless_ Communication_ Module. IMSI. CI20_ Text
        /// urn:x-oca:ocpp:uid:1:569328
        /// This contains the IMSI of the modem’s SIM card.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("imsi", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Imsi { get; set; }
    
    
    }
    
    
    public partial class Anonymous 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("chargingStation", Required = Newtonsoft.Json.Required.Always)]
        public ChargingStationType ChargingStation { get; set; } = new ChargingStationType();
    
        //[Newtonsoft.Json.JsonProperty("reason", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public BootReasonEnumType Reason { get; set; }
    
    
    }
}