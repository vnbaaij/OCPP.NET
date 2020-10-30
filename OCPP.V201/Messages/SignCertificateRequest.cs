namespace OCPP.V201
{
    public partial class SignCertificateRequest
    {
        /// <summary>The Charging Station SHALL send the public key in form of a Certificate Signing Request (CSR) as described in RFC 2986 [22] and then PEM encoded, using the &amp;lt;&amp;lt;signcertificaterequest,SignCertificateRequest&amp;gt;&amp;gt; message.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("csr", Required = Newtonsoft.Json.Required.Always)]
        public string Csr { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("certificate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CertificateSigningUse Certificate { get; set; }
    }
}