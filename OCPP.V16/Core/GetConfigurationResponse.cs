namespace OCPP.V16.Core
{



    public partial class GetConfigurationResponse 
    {
        //[Newtonsoft.Json.JsonProperty("configurationKey", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ConfigurationKey> ConfigurationKey { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("unknownKey", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> UnknownKey { get; set; }
    
    
    }
}