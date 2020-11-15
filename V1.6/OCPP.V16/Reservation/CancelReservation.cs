using OCPP.V16;

namespace OCPP.V16.Reservation
{
    public partial class CancelReservationRequest : RequestBase<CancelReservationRequest> 
    {
        //[Newtonsoft.Json.JsonProperty("reservationId", Required = Newtonsoft.Json.Required.Always)]
        public int ReservationId { get; set; }
    }
}