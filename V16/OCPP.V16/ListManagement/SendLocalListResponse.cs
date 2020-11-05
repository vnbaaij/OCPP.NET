namespace OCPP.V16.ListManagement
{



    public partial class SendLocalListResponse 
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SendLocalListResponseStatus Status { get; set; }
    }
}