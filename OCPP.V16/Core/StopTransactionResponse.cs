using OCPP.Core;

namespace OCPP.Core
{
    public partial class StopTransactionResponse
    {
        ////[Newtonsoft.Json.JsonProperty("idTagInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IdTagInfo IdTagInfo { get; set; }
    }
}