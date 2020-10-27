





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
    
    /// <summary>This contains the current status of the Connector.
    /// </summary>
    
    public enum ConnectorStatusEnumType
    {
        
        Available = 0,
    
        
        Occupied = 1,
    
        
        Reserved = 2,
    
        
        Unavailable = 3,
    
        
        Faulted = 4,
    
    }
    
    
    public partial class Anonymous 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>The time for which the status is reported. If absent time of receipt of the message will be assumed.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset Timestamp { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("connectorStatus", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ConnectorStatusEnumType ConnectorStatus { get; set; }
    
        /// <summary>The id of the EVSE to which the connector belongs for which the the status is reported.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("evseId", Required = Newtonsoft.Json.Required.Always)]
        public int EvseId { get; set; }
    
        /// <summary>The id of the connector within the EVSE for which the status is reported.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("connectorId", Required = Newtonsoft.Json.Required.Always)]
        public int ConnectorId { get; set; }
    
    
    }
}