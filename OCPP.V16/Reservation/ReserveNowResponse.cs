namespace OCPP.V16.Reservation
{
    public partial class ReserveNowResponse 
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ReserveNowResponseStatus Status { get; set; }
    }
}