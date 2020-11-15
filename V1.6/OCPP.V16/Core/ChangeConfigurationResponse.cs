using OCPP.V16;
namespace OCPP.V16.Core
{



    public partial class ChangeConfigurationResponse : ResponseBase<ChangeConfigurationRequest, ChangeConfigurationResponse>
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChangeConfigurationResponseStatus Status { get; set; }
        
         /// <summary>
        /// Create a ChangeConfiguration response.
        /// </summary>
        /// <param name="request">The ChangeConfiguration request leading to this response.</param>
        /// <param name="result">The result.</param>
        public ChangeConfigurationResponse(ChangeConfigurationRequest request) : base(request)
        {
        }

    }
}