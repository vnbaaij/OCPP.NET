namespace OCPP
{
    /// <summary>This contains the status of the log upload.
    /// </summary>

    public enum UploadLogStatus
    {
        
        BadMessage = 0,
    
        
        Idle = 1,
    
        
        NotSupportedOperation = 2,
    
        
        PermissionDenied = 3,
    
        
        Uploaded = 4,
    
        
        UploadFailure = 5,
    
        
        Uploading = 6,
    
        
        AcceptedCanceled = 7,
    
    }
}