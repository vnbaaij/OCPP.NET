namespace OCPP
{
    /// <summary>This contains the type of this event.
    /// The first TransactionEvent of a transaction SHALL contain: "Started" The last TransactionEvent of a transaction SHALL contain: "Ended" All others SHALL contain: "Updated"
    /// </summary>

    public enum TransactionEvent
    {

        Ended = 0,
        Started = 1,
        Updated = 2,

    }
}