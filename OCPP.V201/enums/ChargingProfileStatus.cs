namespace OCPP
{
    /// <summary>Returns whether the Charging Station has been able to process the message successfully. This does not guarantee the schedule will be followed to the letter. There might be other constraints the Charging Station may need to take into account.
    /// </summary>

    public enum ChargingProfileStatus
    {
        
        Accepted = 0,
        Rejected = 1,
    
    }
}