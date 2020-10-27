namespace OCPP.Core
{
    public enum StopTransactionRequestReason
    {
        EmergencyStop,
        EVDisconnected,
        HardReset,
        Local,
        Other,
        PowerLoss,
        Reboot,
        Remote,
        SoftReset,
        UnlockCommand,
        DeAuthorized,
    }
}