namespace OCPP
{
    /// <summary>Attribute data of a variable.
    /// </summary>

    public partial class VariableAttribute 
    {
        //[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Attribute Type { get; set; }
    
        /// <summary>Value of the attribute. May only be omitted when mutability is set to 'WriteOnly'.
        /// 
        /// The Configuration Variable &amp;lt;&amp;lt;configkey-reporting-value-size,ReportingValueSize&amp;gt;&amp;gt; can be used to limit GetVariableResult.attributeValue, VariableAttribute.value and EventData.actualValue. The max size of these values will always remain equal. 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Value { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("mutability", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Mutability Mutability { get; set; }
    
        /// <summary>If true, value will be persistent across system reboots or power down. Default when omitted is false.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("persistent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Persistent { get; set; } = false;
    
        /// <summary>If true, value that will never be changed by the Charging Station at runtime. Default when omitted is false.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("constant", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Constant { get; set; } = false;
    }
}