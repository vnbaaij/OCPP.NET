namespace OCPP.Reservation

{



    public partial class CancelReservationResponse
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CancelReservationResponseStatus Status { get; set; }


    }
}