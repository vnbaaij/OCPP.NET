using OCPP.V201.Core;

namespace OCPP.V201
{
    public partial class ReservationStatusUpdateRequest : RequestBase<ReservationStatusUpdateRequest>    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        /// <summary>The ID of the reservation.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("reservationId", Required = Newtonsoft.Json.Required.Always)]
        public int ReservationId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("reservationUpdateStatus", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ReservationUpdateStatus ReservationUpdateStatus { get; set; }
    }
}