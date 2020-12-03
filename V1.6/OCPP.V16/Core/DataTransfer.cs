namespace OCPP.V16.Core
{
    public record DataTransferRequest (string VendorId, string MessageId = null, string Data = null) : RequestBase<DataTransferRequest>;
}