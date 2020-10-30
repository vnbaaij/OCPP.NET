namespace OCPP.V201
{
    /// <summary>Certificate status information. 
    /// - if all certificates are valid: return 'Accepted'.
    /// - if one of the certificates was revoked, return 'CertificateRevoked'.
    /// </summary>

    public enum AuthorizeCertificateStatus
    {
        
        Accepted = 0,
        SignatureError = 1,
        CertificateExpired = 2,
        CertificateRevoked = 3,
        NoCertificateAvailable = 4,
        CertChainError = 5,
        ContractCancelled = 6,
    
    }
}