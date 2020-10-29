namespace OCPP
{
    public partial class SetVariableData
    {
        //[Newtonsoft.Json.JsonProperty("attribute", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Attribute Attribute { get; set; }

        /// <summary>Value to be assigned to attribute of variable.
        ///
        /// The Configuration Variable <<configkey-configuration-value-size,ConfigurationValueSize>> can be used to limit SetVariableData.attributeValue and VariableCharacteristics.valueList. The max size of these values will always remain equal.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("attributeValue", Required = Newtonsoft.Json.Required.Always)]
        public string AttributeValue { get; set; }

        //[Newtonsoft.Json.JsonProperty("component", Required = Newtonsoft.Json.Required.Always)]
        public Component Component { get; set; } = new Component();

        //[Newtonsoft.Json.JsonProperty("variable", Required = Newtonsoft.Json.Required.Always)]
        public Variable Variable { get; set; } = new Variable();
    }
}