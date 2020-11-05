namespace OCPP.V16.Reservation

{

    public partial class CancelReservationResponse : ResponseBase<CancelReservationRequest, CancelReservationResponse>
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CancelReservationResponseStatus Status { get; set; }

         /// <summary>
        /// Create a CancelReservation response.
        /// </summary>
        /// <param name="request">The CancelReservation request leading to this response.</param>
        /// <param name="result">The result.</param>
        public CancelReservationResponse(CancelReservationRequest request, Result result) : base(request, result)
        {
        }
    }
}