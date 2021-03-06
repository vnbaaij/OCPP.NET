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
    
    /// <summary>Specifies the event notification type of the message.
    /// 
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum EventNotificationEnumType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"HardWiredNotification")]
        HardWiredNotification = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"HardWiredMonitor")]
        HardWiredMonitor = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PreconfiguredMonitor")]
        PreconfiguredMonitor = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"CustomMonitor")]
        CustomMonitor = 3,
    
    }
    
    /// <summary>Type of monitor that triggered this event, e.g. exceeding a threshold value.
    /// 
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum EventTriggerEnumType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Alerting")]
        Alerting = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Delta")]
        Delta = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Periodic")]
        Periodic = 2,
    
    }
    
    /// <summary>A physical or logical component
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ComponentType 
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        [Newtonsoft.Json.JsonProperty("evse", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EVSEType Evse { get; set; }
    
        /// <summary>Name of the component. Name should be taken from the list of standardized component names whenever possible. Case Insensitive. strongly advised to use Camel Case.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        public string Name { get; set; }
    
        /// <summary>Name of instance in case the component exists as multiple instances. Case Insensitive. strongly advised to use Camel Case.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instance", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Instance { get; set; }
    
    
    }
    
    /// <summary>Class to report an event notification for a component-variable.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class EventDataType 
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Identifies the event. This field can be referred to as a cause by other events.
        /// 
        /// </summary>
        [Newtonsoft.Json.JsonProperty("eventId", Required = Newtonsoft.Json.Required.Always)]
        public int EventId { get; set; }
    
        /// <summary>Timestamp of the moment the report was generated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset Timestamp { get; set; }
    
        [Newtonsoft.Json.JsonProperty("trigger", Required = Newtonsoft.Json.Required.Always)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EventTriggerEnumType Trigger { get; set; }
    
        /// <summary>Refers to the Id of an event that is considered to be the cause for this event.
        /// 
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cause", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Cause { get; set; }
    
        /// <summary>Actual value (_attributeType_ Actual) of the variable.
        /// 
        /// The Configuration Variable &amp;lt;&amp;lt;configkey-reporting-value-size,ReportingValueSize&amp;gt;&amp;gt; can be used to limit GetVariableResult.attributeValue, VariableAttribute.value and EventData.actualValue. The max size of these values will always remain equal. 
        /// 
        /// </summary>
        [Newtonsoft.Json.JsonProperty("actualValue", Required = Newtonsoft.Json.Required.Always)]
        public string ActualValue { get; set; }
    
        /// <summary>Technical (error) code as reported by component.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("techCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TechCode { get; set; }
    
        /// <summary>Technical detail information as reported by component.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("techInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TechInfo { get; set; }
    
        /// <summary>_Cleared_ is set to true to report the clearing of a monitored situation, i.e. a 'return to normal'. 
        /// 
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cleared", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Cleared { get; set; }
    
        /// <summary>If an event notification is linked to a specific transaction, this field can be used to specify its transactionId.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transactionId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TransactionId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("component", Required = Newtonsoft.Json.Required.Always)]
        public ComponentType Component { get; set; } = new ComponentType();
    
        /// <summary>Identifies the VariableMonitoring which triggered the event.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("variableMonitoringId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int VariableMonitoringId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("eventNotificationType", Required = Newtonsoft.Json.Required.Always)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EventNotificationEnumType EventNotificationType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("variable", Required = Newtonsoft.Json.Required.Always)]
        public VariableType Variable { get; set; } = new VariableType();
    
    
    }
    
    /// <summary>EVSE
    /// urn:x-oca:ocpp:uid:2:233123
    /// Electric Vehicle Supply Equipment
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class EVSEType 
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Identified_ Object. MRID. Numeric_ Identifier
        /// urn:x-enexis:ecdm:uid:1:569198
        /// EVSE Identifier. This contains a number (&amp;gt; 0) designating an EVSE of the Charging Station.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public int Id { get; set; }
    
        /// <summary>An id to designate a specific connector (on an EVSE) by connector index number.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("connectorId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ConnectorId { get; set; }
    
    
    }
    
    /// <summary>Reference key to a component-variable.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class VariableType 
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Name of the variable. Name should be taken from the list of standardized variable names whenever possible. Case Insensitive. strongly advised to use Camel Case.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        public string Name { get; set; }
    
        /// <summary>Name of instance in case the variable exists as multiple instances. Case Insensitive. strongly advised to use Camel Case.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instance", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Instance { get; set; }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Anonymous 
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Timestamp of the moment this message was generated at the Charging Station.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("generatedAt", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset GeneratedAt { get; set; }
    
        /// <summary>“to be continued” indicator. Indicates whether another part of the report follows in an upcoming notifyEventRequest message. Default value when omitted is false. 
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Tbc { get; set; } = false;
    
        /// <summary>Sequence number of this message. First message starts at 0.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seqNo", Required = Newtonsoft.Json.Required.Always)]
        public int SeqNo { get; set; }
    
        [Newtonsoft.Json.JsonProperty("eventData", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<EventDataType> EventData { get; set; } = new System.Collections.ObjectModel.Collection<EventDataType>();
    
    
    }
}