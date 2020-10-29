namespace OCPP
{
    /// <summary>Status is OK if a value could be returned. Otherwise this will indicate the reason why a value could not be returned.
    /// </summary>

    public enum SetMonitoringStatus
    {
        
        Accepted = 0,
        UnknownComponent = 1,
        UnknownVariable = 2,
        UnsupportedMonitorType = 3,
        Rejected = 4,
        Duplicate = 5,
    
    }
}