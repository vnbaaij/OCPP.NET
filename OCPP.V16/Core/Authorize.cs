using System.Text.Json.Serialization;

namespace OCPP.Core
{
    public partial class AuthorizeRequest
    {
        //[Newtonsoft.Json.JsonProperty("idTag", Required = Newtonsoft.Json.Required.Always)]
        [JsonPropertyName("idTag")]
        public string IdTag { get; set; }

    }
}