namespace OCPP.Core
{



    public partial class RemoteStartTransactionResponse 
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RemoteStartTransactionResponseStatus Status { get; set; }
    
    
    }
}