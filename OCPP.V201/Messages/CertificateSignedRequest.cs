using OCPP.Core;

namespace OCPP.V201
{
    public partial class CertificateSignedRequest : RequestBase<CertificateSignedRequest>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        /// <summary>
        /// The signed PEM encoded X.509 certificate. This can also contain the necessary sub CA certificates. In that case, the order of the bundle should follow the certificate chain, starting from the leaf certificate.
        /// The Configuration Variable &amp;lt;&amp;lt;configkey-max-certificate-chain-size,MaxCertificateChainSize&amp;gt;&amp;gt; can be used to limit the maximum size of this field.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("certificateChain", Required = Newtonsoft.Json.Required.Always)]
        public string CertificateChain { get; set; }

        //[Newtonsoft.Json.JsonProperty("certificate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CertificateSigningUse Certificate { get; set; }


    }
}