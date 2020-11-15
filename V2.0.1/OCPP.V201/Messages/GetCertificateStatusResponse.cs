using OCPP.V201.Core;

namespace OCPP.V201
{
    public partial class GetCertificateStatusResponse : ResponseBase<GetCertificateStatusRequest, GetCertificateStatusResponse>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GetCertificateStatus Status { get; set; }

        //[Newtonsoft.Json.JsonProperty("statusInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public StatusInfo StatusInfo { get; set; }

        /// <summary>OCSPResponse class as defined in &amp;lt;&amp;lt;ref-ocpp_security_24, IETF RFC 6960&amp;gt;&amp;gt;. DER encoded (as defined in &amp;lt;&amp;lt;ref-ocpp_security_24, IETF RFC 6960&amp;gt;&amp;gt;), and then base64 encoded. MAY only be omitted when status is not Accepted.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("ocspResult", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OcspResult { get; set; }

        public GetCertificateStatusResponse(GetCertificateStatusRequest request, Result result)  : base(request, result)
        {

        }
    }
}