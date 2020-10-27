namespace OCPP.Core
{



    public partial class RemoteStopTransactionResponse 
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RemoteStopTransactionResponseStatus Status { get; set; }
    
    
    }
}