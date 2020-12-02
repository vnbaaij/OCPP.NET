
namespace OCPP.V16.Core
{
    public enum OcppAction
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
        UpdateFirmware,
        GetConfiguration,
        UnlockConnector,
        Reset,
        RemoteStartTransaction,
        RemoteStopTransaction,
        ChangeConfiguration,
        ChangeAvailability
    }
}
