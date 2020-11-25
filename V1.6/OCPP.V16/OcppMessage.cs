using OCPP.V16.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OCPP.V16
{

    public class OcppMessage
    {

        public MessageType MessageType { get; set; }

        public Guid MessageId { get; set; }

        public string Payload { get; set; }

        public OcppOperation Action { get; set; }

        public OcppMessage()
        {

        }

        public OcppMessage(MessageType messageType, Guid messageId, string payload, OcppOperation action = OcppOperation.Unknown)
        {
            MessageType = messageType;
            MessageId = messageId;
            Payload = payload;
            Action = action;
        }

        public OcppMessage(ArraySegment<byte> message)
        {
            //var doc = JsonDocument.Parse(result);


            var options = new JsonSerializerOptions
            {
                IgnoreNullValues = true,
                PropertyNameCaseInsensitive = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            };
            //options.Converters.Add(new JsonStringEnumConverter());
            var responseArray = JsonSerializer.Deserialize<object[]>(message, options);

            MessageType = (MessageType)int.Parse(responseArray[0].ToString());
            MessageId = Guid.Parse(responseArray[1].ToString());

            if (responseArray.Length == 4)
            {
                _ = Enum.TryParse<OcppOperation>(responseArray[2].ToString(), out OcppOperation operation);
                Action = operation;
                Payload = responseArray[3].ToString();
            }
            else
            {
                Payload = responseArray[2].ToString();
            }

        }

        public JsonDocument ToJsonDocument()
        {

            string json = $"[{(int)MessageType},{MessageId},{Payload}]";

            return JsonDocument.Parse(json);

        }

        public override string ToString()
        {
            string jsonString;
            if (Action == OcppOperation.Unknown)
                jsonString = $"[{(int)MessageType},\"{MessageId}\",{Payload}]";
            else
                jsonString = $"[{(int)MessageType},\"{MessageId}\",\"{Action}\",{Payload}]";

            return jsonString;

        }

    }
}
