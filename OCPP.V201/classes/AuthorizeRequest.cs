namespace OCPP
{
    public partial class AuthorizeRequest
    {
        //[Newtonsoft.Json.JsonProperty("idToken", Required = Newtonsoft.Json.Required.Always)]
        public IdToken IdToken { get; set; } = new IdToken();

        /// <summary>The X.509 certificated presented by EV and encoded in PEM format.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("certificate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Certificate { get; set; }

        //[Newtonsoft.Json.JsonProperty("iso15118CertificateHashData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<OCSPRequestData> Iso15118CertificateHashData { get; set; }
    }
}