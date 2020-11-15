using OCPP.V16;
namespace OCPP.V16.Core
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