namespace OCPP
{

    public partial class ReservationStatusUpdateRequest
    {
        /// <summary>The ID of the reservation.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("reservationId", Required = Newtonsoft.Json.Required.Always)]
        public int ReservationId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("reservationUpdateStatus", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ReservationUpdateStatus ReservationUpdateStatus { get; set; }
    }
}