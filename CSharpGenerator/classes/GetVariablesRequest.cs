





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
    
    /// <summary>Attribute type for which value is requested. When absent, default Actual is assumed.
    /// </summary>
    
    public enum AttributeEnumType
    {
        
        Actual = 0,
    
        
        Target = 1,
    
        
        MinSet = 2,
    
        
        MaxSet = 3,
    
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
    
    /// <summary>Class to hold parameters for GetVariables request.
    /// </summary>
    
    public partial class GetVariableDataType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("attributeType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AttributeEnumType AttributeType { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("component", Required = Newtonsoft.Json.Required.Always)]
        public ComponentType Component { get; set; } = new ComponentType();
    
        //[Newtonsoft.Json.JsonProperty("variable", Required = Newtonsoft.Json.Required.Always)]
        public VariableType Variable { get; set; } = new VariableType();
    
    
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
    
        //[Newtonsoft.Json.JsonProperty("getVariableData", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<GetVariableDataType> GetVariableData { get; set; } = new System.Collections.ObjectModel.Collection<GetVariableDataType>();
    
    
    }
}