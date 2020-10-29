namespace OCPP
{
    /// <summary>Charge_ Point
    /// urn:x-oca:ocpp:uid:2:233122
    /// The physical system where an Electrical Vehicle (EV) can be charged.
    /// </summary>

    public partial class ChargingStation 
    {
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
        public Modem Modem { get; set; }
    
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
}