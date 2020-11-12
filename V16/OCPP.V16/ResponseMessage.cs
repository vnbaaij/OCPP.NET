using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OCPP.V16
{

    public class ResponseMessage
    {

        public MessageType MessageType { get; }

        public string RequestId { get; }

        public string Payload { get; }

        public ResponseMessage()
        {

        }

        public ResponseMessage(MessageType messageType,string requestId, string payload)
        {
            MessageType = messageType;
            RequestId = requestId;
            Payload = payload;
        }

        public ResponseMessage(ArraySegment<byte> message)
        {
            //var doc = JsonDocument.Parse(result);


            var options = new JsonSerializerOptions
            {
                IgnoreNullValues = true,
                PropertyNameCaseInsensitive = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            };
            options.Converters.Add(new JsonStringEnumConverter());
            var x = JsonSerializer.Deserialize<object>(message, options);
        }

        public JsonDocument ToJsonDocument()
        {

            string json = $"[{(int)MessageType},{RequestId},{Payload}]";

            return JsonDocument.Parse(json);

        }

        public override string ToString() => string.Concat(RequestId, " => ", Payload.ToString());

    }
}
