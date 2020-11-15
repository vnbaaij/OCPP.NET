namespace OCPP.V201
{
    /// <summary>Type of message to be triggered.
    /// </summary>

    public enum MessageTrigger
    {
        
        BootNotification = 0,
        LogStatusNotification = 1,
        FirmwareStatusNotification = 2,
        Heartbeat = 3,
        MeterValues = 4,
        SignChargingStationCertificate = 5,
        SignV2GCertificate = 6,
        StatusNotification = 7,
        TransactionEvent = 8,
        SignCombinedCertificate = 9,
        PublishFirmwareStatusNotification = 10,
    
    }
}