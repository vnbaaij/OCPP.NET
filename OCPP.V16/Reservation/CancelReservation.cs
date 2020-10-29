namespace OCPP.Reservation
{
    
    public partial class CancelReservationRequest 
    {
        //[Newtonsoft.Json.JsonProperty("reservationId", Required = Newtonsoft.Json.Required.Always)]
        public int ReservationId { get; set; }
    }
}