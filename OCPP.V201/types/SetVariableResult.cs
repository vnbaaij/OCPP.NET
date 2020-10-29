namespace OCPP
{
    public partial class SetVariableResult 
    {
        //[Newtonsoft.Json.JsonProperty("attribute", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Attribute Attribute { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("attributeStatus", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SetVariableStatus AttributeStatus { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("attributeStatusInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public StatusInfo AttributeStatusInfo { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("component", Required = Newtonsoft.Json.Required.Always)]
        public Component Component { get; set; } = new Component();
    
        //[Newtonsoft.Json.JsonProperty("variable", Required = Newtonsoft.Json.Required.Always)]
        public Variable Variable { get; set; } = new Variable();
    }
}