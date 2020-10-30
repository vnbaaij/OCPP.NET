namespace OCPP.V201
{
    /// <summary>Class to report components, variables and variable attributes and characteristics.
    /// </summary>

    public partial class ReportData 
    {
        //[Newtonsoft.Json.JsonProperty("component", Required = Newtonsoft.Json.Required.Always)]
        public Component Component { get; set; } = new Component();
    
        //[Newtonsoft.Json.JsonProperty("variable", Required = Newtonsoft.Json.Required.Always)]
        public Variable Variable { get; set; } = new Variable();
    
        //[Newtonsoft.Json.JsonProperty("variableAttribute", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<VariableAttribute> VariableAttribute { get; set; } = new System.Collections.ObjectModel.Collection<VariableAttribute>();
    
        //[Newtonsoft.Json.JsonProperty("variableCharacteristics", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public VariableCharacteristics VariableCharacteristics { get; set; }
    }
}