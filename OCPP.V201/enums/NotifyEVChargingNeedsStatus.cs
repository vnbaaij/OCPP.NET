namespace OCPP
{
    /// <summary>Returns whether the CSMS has been able to process the message successfully. It does not imply that the evChargingNeeds can be met with the current charging profile.
    /// </summary>

    public enum NotifyEVChargingNeedsStatus
    {
        
        Accepted = 0,
        Rejected = 1,
        Processing = 2,
    
    }
}