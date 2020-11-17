using OCPP.V16;
namespace OCPP.V16.Core
{
    public partial class ClearCacheResponse : ResponseBase<ClearCacheResponse>
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ClearCacheResponseStatus Status { get; set; }

         /// <summary>
        /// Create a ClearCache response.
        /// </summary>
        /// <param name="request">The ClearCache request leading to this response.</param>
        /// <param name="result">The result.</param>
        public ClearCacheResponse() : base()
        {
        }
    }
}