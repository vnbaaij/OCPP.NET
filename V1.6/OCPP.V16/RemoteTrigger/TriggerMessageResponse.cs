using OCPP.V16.Core;
using System.Text.Json.Serialization;

namespace OCPP.V16.RemoteTrigger
{



    public partial class TriggerMessageResponse : ResponseBase<TriggerMessageRequest, TriggerMessageResponse>
    {
        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public TriggerMessageStatus Status { get; set; }

        [JsonPropertyName("requestedMessage")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public OcppAction? Operation { get; set; }
         /// <summary>
        /// Create a TriggerMessage response.
        /// </summary>
        /// <param name="request">The TriggerMessage request leading to this response.</param>
        /// <param name="result">The result.</param>
        public TriggerMessageResponse(TriggerMessageRequest request) : base(request)
        {

        }
    }
}