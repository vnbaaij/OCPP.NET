





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
    
    /// <summary>Type of message to be triggered.
    /// </summary>
    
    public enum MessageTriggerEnumType
    {
        
        BootNotification = 0,
    
        
        LogStatusNotification = 1,
    
        
        FirmwareStatusNotification = 2,
    
        
        Heartbeat = 3,
    
        
        MeterValues = 4,
    
        
        SignChargingStationCertificate = 5,
    
        
        SignV2GCertificate = 6,
    
        
        StatusNotification = 7,
    
        
        TransactionEvent = 8,
    
        
        SignCombinedCertificate = 9,
    
        
        PublishFirmwareStatusNotification = 10,
    
    }
    
    /// <summary>EVSE
    /// urn:x-oca:ocpp:uid:2:233123
    /// Electric Vehicle Supply Equipment
    /// </summary>
    
    public partial class EVSEType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Identified_ Object. MRID. Numeric_ Identifier
        /// urn:x-enexis:ecdm:uid:1:569198
        /// EVSE Identifier. This contains a number (&amp;gt; 0) designating an EVSE of the Charging Station.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public int Id { get; set; }
    
        /// <summary>An id to designate a specific connector (on an EVSE) by connector index number.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("connectorId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ConnectorId { get; set; }
    
    
    }
    
    
    public partial class Anonymous 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("evse", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EVSEType Evse { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("requestedMessage", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MessageTriggerEnumType RequestedMessage { get; set; }
    
    
    }
}