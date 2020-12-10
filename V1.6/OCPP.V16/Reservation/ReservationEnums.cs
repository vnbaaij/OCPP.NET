using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPP.V16.Reservation
{
    public enum CancelReservationStatus
    {
        Accepted,
        Rejected,
    }

    public enum ReservationStatus
    {
        Accepted,
        Faulted,
        Occupied,
        Rejected,
        Unavailable,
    }
}
