namespace OCPP
{
    /// <summary>Class to hold results of GetVariables request.
    /// </summary>

    public partial class GetVariableResult 
    {
        
    
        //[Newtonsoft.Json.JsonProperty("attributeStatusInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public StatusInfo AttributeStatusInfo { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("attributeStatus", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GetVariableStatus AttributeStatus { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("attribute", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Attribute Attribute { get; set; }
    
        /// <summary>Value of requested attribute  of component-variable. This field can only be empty when the given status is NOT accepted.
        /// 
        /// The Configuration Variable &amp;lt;&amp;lt;configkey-reporting-value-size,ReportingValueSize&amp;gt;&amp;gt; can be used to limit GetVariableResult.attributeValue, VariableAttribute.value and EventData.actualValue. The max size of these values will always remain equal. 
        /// 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("attributeValue", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AttributeValue { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("component", Required = Newtonsoft.Json.Required.Always)]
        public Component Component { get; set; } = new Component();
    
        //[Newtonsoft.Json.JsonProperty("variable", Required = Newtonsoft.Json.Required.Always)]
        public Variable Variable { get; set; } = new Variable();
    
    
    }
}