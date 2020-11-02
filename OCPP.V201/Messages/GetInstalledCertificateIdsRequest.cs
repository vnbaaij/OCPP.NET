using OCPP.Core;

namespace OCPP.V201
{
    public partial class GetInstalledCertificateIdsRequest : RequestBase<GetInstalledCertificateIdsRequest>    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
        /// <summary>Indicates the  of certificates requested. When omitted, all certificate s are requested.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("certificate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore, ItemConverter = of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public System.Collections.Generic.ICollection<GetCertificateIdUse> Certificate { get; set; }
    }
}