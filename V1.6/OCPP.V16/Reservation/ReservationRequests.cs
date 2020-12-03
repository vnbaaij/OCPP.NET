using System;

namespace OCPP.V16.Reservation
{
    public record CancelReservationRequest(int ReservationId) : RequestBase<CancelReservationRequest>;
    public record ReserveNowRequest(int ConnectorId, DateTime ExpiryDate, string IdTag, int ReservationId, string ParentIdTag = null) : RequestBase<ReserveNowRequest>;
}
