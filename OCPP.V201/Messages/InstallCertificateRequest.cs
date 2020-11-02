using OCPP.Core;

namespace OCPP.V201
{
    public partial class InstallCertificateRequest : RequestBase<InstallCertificateRequest>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        //[Newtonsoft.Json.JsonProperty("certificate", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public InstallCertificateUse CertificateType { get; set; }

        /// <summary>A PEM encoded X.509 certificate.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("certificate", Required = Newtonsoft.Json.Required.Always)]
        public string Certificate { get; set; }
    }
}