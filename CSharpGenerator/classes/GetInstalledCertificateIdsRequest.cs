namespace OCPP
{

    public partial class GetInstalledCertificateIdsRequest
    {
        /// <summary>Indicates the  of certificates requested. When omitted, all certificate s are requested.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("certificate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore, ItemConverter = of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public System.Collections.Generic.ICollection<GetCertificateIdUse> Certificate { get; set; }
    }
}