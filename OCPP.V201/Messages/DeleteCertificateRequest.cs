using OCPP.Core;

namespace OCPP.V201
{
    public partial class DeleteCertificateRequest : RequestBase<DeleteCertificateRequest>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        //[Newtonsoft.Json.JsonProperty("certificateHashData", Required = Newtonsoft.Json.Required.Always)]
        public CertificateHashData CertificateHashData { get; set; } = new CertificateHashData();
    }
}