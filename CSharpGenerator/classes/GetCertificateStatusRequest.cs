namespace OCPP
{public partial class GetCertificateStatusRequest
    {
        //[Newtonsoft.Json.JsonProperty("ocspRequestData", Required = Newtonsoft.Json.Required.Always)]
        public OCSPRequestData OcspRequestData { get; set; } = new OCSPRequestData();
    }
}