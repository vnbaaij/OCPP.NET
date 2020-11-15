namespace OCPP.V201
{
    /// <summary>Class to report components, variables and variable attributes and characteristics.
    /// </summary>

    public partial class ComponentVariable 
    {
        //[Newtonsoft.Json.JsonProperty("component", Required = Newtonsoft.Json.Required.Always)]
        public Component Component { get; set; } = new Component();
    
        //[Newtonsoft.Json.JsonProperty("variable", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Variable Variable { get; set; }
    }
}