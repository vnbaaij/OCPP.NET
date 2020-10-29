namespace OCPP
{
    /// <summary>A monitoring setting for a variable.
    /// </summary>

    public partial class VariableMonitoring 
    {
        
    
        /// <summary>Identifies the monitor.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public int Id { get; set; }
    
        /// <summary>Monitor only active when a transaction is ongoing on a component relevant to this transaction. 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("transaction", Required = Newtonsoft.Json.Required.Always)]
        public bool Transaction { get; set; }
    
        /// <summary>Value for threshold or delta monitoring.
        /// For Periodic or PeriodicClockAligned this is the interval in seconds.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Always)]
        public double Value { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Monitor Type { get; set; }
    
        /// <summary>The severity that will be assigned to an event that is triggered by this monitor. The severity range is 0-9, with 0 as the highest and 9 as the lowest severity level.
        /// 
        /// The severity levels have the following meaning: +
        /// *0-Danger* +
        /// Indicates lives are potentially in danger. Urgent attention is needed and action should be taken immediately. +
        /// *1-Hardware Failure* +
        /// Indicates that the Charging Station is unable to continue regular operations due to Hardware issues. Action is required. +
        /// *2-System Failure* +
        /// Indicates that the Charging Station is unable to continue regular operations due to software or minor hardware issues. Action is required. +
        /// *3-Critical* +
        /// Indicates a critical error. Action is required. +
        /// *4-Error* +
        /// Indicates a non-urgent error. Action is required. +
        /// *5-Alert* +
        /// Indicates an alert event. Default severity for any  of monitoring event.  +
        /// *6-Warning* +
        /// Indicates a warning event. Action may be required. +
        /// *7-Notice* +
        /// Indicates an unusual event. No immediate action is required. +
        /// *8-Informational* +
        /// Indicates a regular operational event. May be used for reporting, measuring throughput, etc. No action is required. +
        /// *9-Debug* +
        /// Indicates information useful to developers for debugging, not useful during operations.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("severity", Required = Newtonsoft.Json.Required.Always)]
        public int Severity { get; set; }
    
    
    }
}