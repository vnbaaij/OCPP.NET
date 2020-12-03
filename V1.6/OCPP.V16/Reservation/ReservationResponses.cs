namespace OCPP.V16.Reservation
{
    public record CancelReservationResponse(CancelReservationRequest Request, CancelReservationStatus Status) : ResponseBase<CancelReservationRequest, CancelReservationResponse>(Request);
    public record ReserveNowResponse(ReserveNowRequest Request, ReservationStatus Status) : ResponseBase<ReserveNowRequest, ReserveNowResponse>(Request);
}
