using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPP.V16.Reservation
{
    public record CancelReservationRequest(int ReservationId) : RequestBase<CancelReservationRequest>;
    public record ReserveNowRequest(int ConnectorId, DateTime ExpiryDate, string IdTag, int ReservationId, string ParentIdTag = null) : RequestBase<ReserveNowRequest>;
}
