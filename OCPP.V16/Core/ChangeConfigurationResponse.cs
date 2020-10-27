namespace OCPP.Core
{



    public partial class ChangeConfigurationResponse 
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChangeConfigurationResponseStatus Status { get; set; }
    
    
    }
}