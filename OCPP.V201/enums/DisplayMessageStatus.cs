namespace OCPP.V201
{
    /// <summary>This indicates whether the Charging Station is able to display the message.
    /// </summary>

    public enum DisplayMessageStatus
    {
        
        Accepted = 0,
        NotSupportedMessageFormat = 1,
        Rejected = 2,
        NotSupportedPriority = 3,
        NotSupportedState = 4,
        UnknownTransaction = 5,
    
    }
}