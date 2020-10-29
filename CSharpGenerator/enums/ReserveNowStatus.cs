namespace OCPP
{
    /// <summary>This indicates the success or failure of the reservation.
    /// </summary>

    public enum ReserveNowStatus
    {
        
        Accepted = 0,
        Faulted = 1,
        Occupied = 2,
        Rejected = 3,
        Unavailable = 4,
    
    }
}