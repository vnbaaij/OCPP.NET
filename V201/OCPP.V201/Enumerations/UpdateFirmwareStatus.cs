namespace OCPP.V201
{
    /// <summary>This field indicates whether the Charging Station was able to accept the request.
    /// 
    /// </summary>

    public enum UpdateFirmwareStatus
    {
        
        Accepted = 0,
        Rejected = 1,
        AcceptedCanceled = 2,
        InvalidCertificate = 3,
        RevokedCertificate = 4,
    
    }
}