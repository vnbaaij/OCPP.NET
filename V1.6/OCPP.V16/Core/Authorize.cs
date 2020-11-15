using System.Text.Json.Serialization;

namespace OCPP.V16.Core
{
    public partial class AuthorizeRequest : RequestBase<AuthorizeRequest>
    {
        //[Newtonsoft.Json.JsonProperty("idTag", Required = Newtonsoft.Json.Required.Always)]
        [JsonPropertyName("idTag")]
        public string IdTag { get; set; }

    }
}