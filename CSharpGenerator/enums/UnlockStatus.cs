namespace OCPP
{
    /// <summary>This indicates whether the Charging Station has unlocked the connector.
    /// </summary>

    public enum UnlockStatus
    {
        
        Unlocked = 0,
    
        
        UnlockFailed = 1,
    
        
        OngoingAuthorizedTransaction = 2,
    
        
        UnknownConnector = 3,
    
    }
}