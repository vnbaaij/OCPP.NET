using OCPP.V16;
namespace OCPP.V16.Core
{



    public partial class GetConfigurationResponse : ResponseBase<GetConfigurationRequest, GetConfigurationResponse>
    {
        //[Newtonsoft.Json.JsonProperty("configurationKey", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ConfigurationKey> ConfigurationKey { get; set; }

        //[Newtonsoft.Json.JsonProperty("unknownKey", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> UnknownKey { get; set; }
/// <summary>
        /// Create a response.
        /// </summary>
        /// <param name="request">The request leading to this response.</param>
        /// <param name="result">The result.</param>
        public GetConfigurationResponse(GetConfigurationRequest request) : base(request)
        {

        }
    }
}
