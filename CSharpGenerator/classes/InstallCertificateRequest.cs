namespace OCPP
{

    public partial class InstallCertificateRequest
    {
        
    
        //[Newtonsoft.Json.JsonProperty("certificate", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public InstallCertificateUse CertificateType { get; set; }
    
        /// <summary>A PEM encoded X.509 certificate.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("certificate", Required = Newtonsoft.Json.Required.Always)]
        public string Certificate { get; set; }
    
    
    }
}