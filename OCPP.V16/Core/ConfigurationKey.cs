namespace OCPP.Core
{
    public partial class ConfigurationKey 
    {
        //[Newtonsoft.Json.JsonProperty("key", Required = Newtonsoft.Json.Required.Always)]
        public string Key { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("readonly", Required = Newtonsoft.Json.Required.Always)]
        public bool Readonly { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Value { get; set; }
    }
}