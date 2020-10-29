namespace OCPP
{
    /// <summary>Fixed read-only parameters of a variable.
    /// </summary>

    public partial class VariableCharacteristics 
    {
        
    
        /// <summary>Unit of the variable. When the transmitted value has a unit, this field SHALL be included.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("unit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Unit { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Data Data { get; set; }
    
        /// <summary>Minimum possible value of this variable.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("minLimit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double MinLimit { get; set; }
    
        /// <summary>Maximum possible value of this variable. When the data of this Variable is String, OptionList, SequenceList or MemberList, this field defines the maximum length of the (CSV) string.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("maxLimit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double MaxLimit { get; set; }
    
        /// <summary>Allowed values when variable is Option/Member/SequenceList. 
        /// 
        /// * OptionList: The (Actual) Variable value must be a single value from the reported (CSV) enumeration list.
        /// 
        /// * MemberList: The (Actual) Variable value  may be an (unordered) (sub-)set of the reported (CSV) valid values list.
        /// 
        /// * SequenceList: The (Actual) Variable value  may be an ordered (priority, etc)  (sub-)set of the reported (CSV) valid values.
        /// 
        /// This is a comma separated list.
        /// 
        /// The Configuration Variable &amp;lt;&amp;lt;configkey-configuration-value-size,ConfigurationValueSize&amp;gt;&amp;gt; can be used to limit SetVariableData.attributeValue and VariableCharacteristics.valueList. The max size of these values will always remain equal. 
        /// 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("valuesList", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ValuesList { get; set; }
    
        /// <summary>Flag indicating if this variable supports monitoring. 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("supportsMonitoring", Required = Newtonsoft.Json.Required.Always)]
        public bool SupportsMonitoring { get; set; }
    
    
    }
}