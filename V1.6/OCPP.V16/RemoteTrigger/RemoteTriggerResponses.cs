using System.Text.Json.Serialization;
using OCPP.V16.Core;

namespace OCPP.V16.RemoteTrigger
{
    public record TriggerMessageResponse(TriggerMessageRequest Request, TriggerMessageStatus Status) : ResponseBase<TriggerMessageRequest, TriggerMessageResponse>(Request)
    {

        [JsonPropertyName("requestedMessage")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public OcppAction? Operation { get; set; }

    }
}