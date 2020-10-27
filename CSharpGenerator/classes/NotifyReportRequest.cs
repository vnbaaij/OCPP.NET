





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
    
    /// <summary>Attribute: Actual, MinSet, MaxSet, etc.
    /// Defaults to Actual if absent.
    /// </summary>
    
    public enum AttributeEnumType
    {
        
        Actual = 0,
    
        
        Target = 1,
    
        
        MinSet = 2,
    
        
        MaxSet = 3,
    
    }
    
    /// <summary>Data type of this variable.
    /// </summary>
    
    public enum DataEnumType
    {
        
        String = 0,
    
        
        Decimal = 1,
    
        
        Integer = 2,
    
        
        DateTime = 3,
    
        
        Boolean = 4,
    
        
        OptionList = 5,
    
        
        SequenceList = 6,
    
        
        MemberList = 7,
    
    }
    
    /// <summary>Defines the mutability of this attribute. Default is ReadWrite when omitted.
    /// </summary>
    
    public enum MutabilityEnumType
    {
        
        ReadOnly = 0,
    
        
        WriteOnly = 1,
    
        
        ReadWrite = 2,
    
    }
    
    /// <summary>A physical or logical component
    /// </summary>
    
    public partial class ComponentType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("evse", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EVSEType Evse { get; set; }
    
        /// <summary>Name of the component. Name should be taken from the list of standardized component names whenever possible. Case Insensitive. strongly advised to use Camel Case.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        public string Name { get; set; }
    
        /// <summary>Name of instance in case the component exists as multiple instances. Case Insensitive. strongly advised to use Camel Case.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("instance", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Instance { get; set; }
    
    
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
    
    /// <summary>Class to report components, variables and variable attributes and characteristics.
    /// </summary>
    
    public partial class ReportDataType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("component", Required = Newtonsoft.Json.Required.Always)]
        public ComponentType Component { get; set; } = new ComponentType();
    
        //[Newtonsoft.Json.JsonProperty("variable", Required = Newtonsoft.Json.Required.Always)]
        public VariableType Variable { get; set; } = new VariableType();
    
        //[Newtonsoft.Json.JsonProperty("variableAttribute", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<VariableAttributeType> VariableAttribute { get; set; } = new System.Collections.ObjectModel.Collection<VariableAttributeType>();
    
        //[Newtonsoft.Json.JsonProperty("variableCharacteristics", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public VariableCharacteristicsType VariableCharacteristics { get; set; }
    
    
    }
    
    /// <summary>Attribute data of a variable.
    /// </summary>
    
    public partial class VariableAttributeType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AttributeEnumType Type { get; set; }
    
        /// <summary>Value of the attribute. May only be omitted when mutability is set to 'WriteOnly'.
        /// 
        /// The Configuration Variable &amp;lt;&amp;lt;configkey-reporting-value-size,ReportingValueSize&amp;gt;&amp;gt; can be used to limit GetVariableResult.attributeValue, VariableAttribute.value and EventData.actualValue. The max size of these values will always remain equal. 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Value { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("mutability", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MutabilityEnumType Mutability { get; set; }
    
        /// <summary>If true, value will be persistent across system reboots or power down. Default when omitted is false.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("persistent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Persistent { get; set; } = false;
    
        /// <summary>If true, value that will never be changed by the Charging Station at runtime. Default when omitted is false.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("constant", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Constant { get; set; } = false;
    
    
    }
    
    /// <summary>Fixed read-only parameters of a variable.
    /// </summary>
    
    public partial class VariableCharacteristicsType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Unit of the variable. When the transmitted value has a unit, this field SHALL be included.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("unit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Unit { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("dataType", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DataEnumType DataType { get; set; }
    
        /// <summary>Minimum possible value of this variable.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("minLimit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double MinLimit { get; set; }
    
        /// <summary>Maximum possible value of this variable. When the datatype of this Variable is String, OptionList, SequenceList or MemberList, this field defines the maximum length of the (CSV) string.
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
    
    /// <summary>Reference key to a component-variable.
    /// </summary>
    
    public partial class VariableType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Name of the variable. Name should be taken from the list of standardized variable names whenever possible. Case Insensitive. strongly advised to use Camel Case.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        public string Name { get; set; }
    
        /// <summary>Name of instance in case the variable exists as multiple instances. Case Insensitive. strongly advised to use Camel Case.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("instance", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Instance { get; set; }
    
    
    }
    
    
    public partial class Anonymous 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>The id of the GetReportRequest  or GetBaseReportRequest that requested this report
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("requestId", Required = Newtonsoft.Json.Required.Always)]
        public int RequestId { get; set; }
    
        /// <summary>Timestamp of the moment this message was generated at the Charging Station.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("generatedAt", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset GeneratedAt { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("reportData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ReportDataType> ReportData { get; set; }
    
        /// <summary>“to be continued” indicator. Indicates whether another part of the report follows in an upcoming notifyReportRequest message. Default value when omitted is false.
        /// 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("tbc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Tbc { get; set; } = false;
    
        /// <summary>Sequence number of this message. First message starts at 0.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("seqNo", Required = Newtonsoft.Json.Required.Always)]
        public int SeqNo { get; set; }
    
    
    }
}