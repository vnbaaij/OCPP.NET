﻿using System;
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

        public string RequestId { get; set; }

        public string Payload { get; set; }

        public string Action { get; set; }

        public OcppMessage()
        {

        }

        public OcppMessage(MessageType messageType,string requestId, string payload, string action = null)
        {
            MessageType = messageType;
            RequestId = requestId;
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
            RequestId = responseArray[1].ToString();

            if (responseArray.Length == 4)
            {
                Action = responseArray[2].ToString();
                Payload = responseArray[3].ToString();
            }
            else
            {
                Payload = responseArray[2].ToString();
            }

        }

        public JsonDocument ToJsonDocument()
        {

            string json = $"[{(int)MessageType},{RequestId},{Payload}]";

            return JsonDocument.Parse(json);

        }

        public override string ToString()
        {
            string jsonString;
            if (string.IsNullOrEmpty(Action))
                jsonString = $"[{(int)MessageType},\"{RequestId}\",{Payload}]";
            else
                jsonString = $"[{(int)MessageType},\"{RequestId}\",\"{Action}\",{Payload}]";

            return jsonString;

        }

    }
}
