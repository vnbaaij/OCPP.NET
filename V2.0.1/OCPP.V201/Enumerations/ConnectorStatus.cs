namespace OCPP.V201
{
    /// <summary>This contains the current status of the Connector.
    /// </summary>

    public enum ConnectorStatus
    {
        
        Available = 0,
        Occupied = 1,
        Reserved = 2,
        Unavailable = 3,
        Faulted = 4,
    
    }
}