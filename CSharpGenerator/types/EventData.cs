namespace OCPP
{
    /// <summary>Class to report an event notification for a component-variable.
    /// </summary>

    public partial class EventData 
    {
        
    
        /// <summary>Identifies the event. This field can be referred to as a cause by other events.
        /// 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("eventId", Required = Newtonsoft.Json.Required.Always)]
        public int EventId { get; set; }
    
        /// <summary>Timestamp of the moment the report was generated.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset Timestamp { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("trigger", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EventTrigger Trigger { get; set; }
    
        /// <summary>Refers to the Id of an event that is considered to be the cause for this event.
        /// 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("cause", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Cause { get; set; }
    
        /// <summary>Actual value (_attribute_ Actual) of the variable.
        /// 
        /// The Configuration Variable &amp;lt;&amp;lt;configkey-reporting-value-size,ReportingValueSize&amp;gt;&amp;gt; can be used to limit GetVariableResult.attributeValue, VariableAttribute.value and EventData.actualValue. The max size of these values will always remain equal. 
        /// 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("actualValue", Required = Newtonsoft.Json.Required.Always)]
        public string ActualValue { get; set; }
    
        /// <summary>Technical (error) code as reported by component.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("techCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TechCode { get; set; }
    
        /// <summary>Technical detail information as reported by component.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("techInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TechInfo { get; set; }
    
        /// <summary>_Cleared_ is set to true to report the clearing of a monitored situation, i.e. a 'return to normal'. 
        /// 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("cleared", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Cleared { get; set; }
    
        /// <summary>If an event notification is linked to a specific transaction, this field can be used to specify its transactionId.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("transactionId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TransactionId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("component", Required = Newtonsoft.Json.Required.Always)]
        public Component Component { get; set; } = new Component();
    
        /// <summary>Identifies the VariableMonitoring which triggered the event.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("variableMonitoringId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int VariableMonitoringId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("eventNotification", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EventNotification EventNotification { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("variable", Required = Newtonsoft.Json.Required.Always)]
        public Variable Variable { get; set; } = new Variable();
    
    
    }
}