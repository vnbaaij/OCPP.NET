using System.Text.Json.Serialization;

namespace OCPP.Core
{
    public partial class AuthorizeResponse
    {
        //[Newtonsoft.Json.JsonProperty("idTagInfo", Required = Newtonsoft.Json.Required.Always)]
        [JsonPropertyName("idTagInfo")]
        public IdTagInfo IdTagInfo { get; set; } = new IdTagInfo();

    }
}