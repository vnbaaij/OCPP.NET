namespace OCPP.V16.RemoteTrigger
{
    public enum MessageTrigger
    {
        BootNotification,
        DiagnosticsStatusNotification,
        FirmwareStatusNotification,
        Heartbeat,
        MeterValues,
        StatusNotification,
    }

    public enum TriggerMessageStatus
    {
        Accepted,
        Rejected,
        NotImplemented,
    }
}
