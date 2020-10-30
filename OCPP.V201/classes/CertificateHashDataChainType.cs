namespace OCPP.V201
{
    public partial class CertificateHashDataChain 
    {
        //[Newtonsoft.Json.JsonProperty("certificateHashData", Required = Newtonsoft.Json.Required.Always)]
        public CertificateHashData CertificateHashData { get; set; } = new CertificateHashData();
    
        //[Newtonsoft.Json.JsonProperty("certificate", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GetCertificateIdUse Certificate { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("childCertificateHashData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<CertificateHashData> ChildCertificateHashData { get; set; }
    }
}