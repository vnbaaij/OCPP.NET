namespace OCPP
{
    /// <summary>This contains the progress status of the firmware installation.
    /// </summary>

    public enum FirmwareStatus
    {
        
        Downloaded = 0,
    
        
        DownloadFailed = 1,
    
        
        Downloading = 2,
    
        
        DownloadScheduled = 3,
    
        
        DownloadPaused = 4,
    
        
        Idle = 5,
    
        
        InstallationFailed = 6,
    
        
        Installing = 7,
    
        
        Installed = 8,
    
        
        InstallRebooting = 9,
    
        
        InstallScheduled = 10,
    
        
        InstallVerificationFailed = 11,
    
        
        InvalidSignature = 12,
    
        
        SignatureVerified = 13,
    
    }
}