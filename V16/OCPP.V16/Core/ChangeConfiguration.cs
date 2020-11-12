namespace OCPP.V16.Core
{
    public partial class ChangeConfigurationRequest : RequestBase<ChangeConfigurationRequest> 
    {
        //[Newtonsoft.Json.JsonProperty("key", Required = Newtonsoft.Json.Required.Always)]
        public string Key { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Always)]
        public string Value { get; set; }
    }
}