
namespace OCPP.V16.Core
{
    public enum OcppOperation
    {
        Unknown,
        BootNotification,
        Authorize,
        StartTransaction,
        StopTransaction,
        Heartbeat,
        MeterValues,
        ClearCache,
        DiagnosticsStatusNotification,
        FirmwareStatusNotification,
        StatusNotification,
        DataTransfer,
        TriggerMessage,
        UpdateFirmware
    }
}
