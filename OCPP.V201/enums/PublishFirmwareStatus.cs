namespace OCPP.V201
{
    /// <summary>This contains the progress status of the publishfirmware
    /// installation.
    /// </summary>

    public enum PublishFirmwareStatus
    {
        
        Idle = 0,
        DownloadScheduled = 1,
        Downloading = 2,
        Downloaded = 3,
        Published = 4,
        DownloadFailed = 5,
        DownloadPaused = 6,
        InvalidChecksum = 7,
        ChecksumVerified = 8,
        PublishFailed = 9,
    
    }
}