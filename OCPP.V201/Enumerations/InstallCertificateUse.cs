namespace OCPP.V201
{
    /// <summary>
    /// Indicates the certificate type that is sent.
    /// </summary>

    public enum InstallCertificateUse
    {
        V2GRootCertificate = 0,
        MORootCertificate = 1,
        CSMSRootCertificate = 2,
        ManufacturerRootCertificate = 3,
    }
}