using OCPP.Core;

namespace OCPP.V201
{
    public partial class GetCertificateStatusRequest : RequestBase<GetCertificateStatusRequest>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        //[Newtonsoft.Json.JsonProperty("ocspRequestData", Required = Newtonsoft.Json.Required.Always)]
        public OCSPRequestData OcspRequestData { get; set; } = new OCSPRequestData();
    }
}