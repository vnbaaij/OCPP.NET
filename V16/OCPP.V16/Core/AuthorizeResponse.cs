using System.Text.Json.Serialization;
namespace OCPP.V16.Core
{
    public partial class AuthorizeResponse : ResponseBase<AuthorizeRequest, AuthorizeResponse>
    {
        //[Newtonsoft.Json.JsonProperty("idTagInfo", Required = Newtonsoft.Json.Required.Always)]
        [JsonPropertyName("idTagInfo")]
        public IdTagInfo IdTagInfo { get; set; } = new IdTagInfo();

        /// <summary>
        /// Create a response.
        /// </summary>
        /// <param name="request">The request leading to this response.</param>
        /// <param name="result">The result.</param>
        public AuthorizeResponse(AuthorizeRequest request, Result result) : base(request, result)
        {
        }
    }
}