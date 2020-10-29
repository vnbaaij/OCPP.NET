namespace OCPP
{
    /// <summary>This indicates the success or failure of the data transfer.
    /// </summary>

    public enum DataTransferStatus
    {
        
        Accepted = 0,
        Rejected = 1,
        UnknownMessageId = 2,
        UnknownVendorId = 3,
    
    }
}