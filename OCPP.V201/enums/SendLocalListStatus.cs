namespace OCPP
{
    /// <summary>This indicates whether the Charging Station has successfully received and applied the update of the Local Authorization List.
    /// </summary>

    public enum SendLocalListStatus
    {
        
        Accepted = 0,
        Failed = 1,
        VersionMismatch = 2,
    
    }
}