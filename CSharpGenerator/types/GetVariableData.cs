namespace OCPP
{
    /// <summary>Class to hold parameters for GetVariables request.
    /// </summary>

    public partial class GetVariableData 
    {
        //[Newtonsoft.Json.JsonProperty("attribute", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Attribute Attribute { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("component", Required = Newtonsoft.Json.Required.Always)]
        public Component Component { get; set; } = new Component();
    
        //[Newtonsoft.Json.JsonProperty("variable", Required = Newtonsoft.Json.Required.Always)]
        public Variable Variable { get; set; } = new Variable();
    }
}