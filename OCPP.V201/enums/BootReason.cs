namespace OCPP.V201
{
    /// <summary>This contains the reason for sending this message to the CSMS.
    /// </summary>

    public enum BootReason
    {
        
        ApplicationReset = 0,
        FirmwareUpdate = 1,
        LocalReset = 2,
        PowerUp = 3,
        RemoteReset = 4,
        ScheduledReset = 5,
        Triggered = 6,
        Unknown = 7,
        Watchdog = 8,
    
    }
}