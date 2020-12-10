namespace OCPP.V16.ListManagement
{
    public enum UpdateStatus
    {
        Accepted,
        Failed,
        NotSupported,
        VersionMismatch,
    }

    public enum UpdateType
    {
        Differential,
        Full,
    }
}
