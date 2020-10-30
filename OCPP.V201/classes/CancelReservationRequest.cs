namespace OCPP.V201
{
    public partial class CancelReservationRequest
    {
        /// <summary>
        /// Id of the reservation to cancel.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("reservationId", Required = Newtonsoft.Json.Required.Always)]
        public int ReservationId { get; set; }
    }
}