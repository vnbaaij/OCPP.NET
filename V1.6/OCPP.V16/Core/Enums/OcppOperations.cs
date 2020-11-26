
namespace OCPP.V16.Core
{
    public enum OcppOperation
    {
        Unknown,
        BootNotification,
        Authorize,
        ClearCache,
        TriggerMessage,
        DiagnosticsStatusNotification,
        FirmwareStatusNotification,
        Heartbeat,
        MeterValues,
        StatusNotification,
        DataTransfer,
        UpdateFirmware
    }
}
