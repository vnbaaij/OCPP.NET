namespace OCPP.V201
{
    public partial class DeleteCertificateRequest
    {
        //[Newtonsoft.Json.JsonProperty("certificateHashData", Required = Newtonsoft.Json.Required.Always)]
        public CertificateHashData CertificateHashData { get; set; } = new CertificateHashData();
    }
}