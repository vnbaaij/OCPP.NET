using System;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

using OCPP.V16.Core;

namespace OCPP.V16
{

    public class OcppMessage
    {
        private const bool logVerbose = true;
        public MessageType MessageType { get; set; }

        public Guid MessageId { get; set; }

        public string Payload { get; set; }

        public OcppAction Action { get; set; }

        public OcppMessage()
        {

        }

        public OcppMessage(MessageType messageType, Guid messageId, string payload, OcppAction action = OcppAction.Unknown)
        {
            MessageType = messageType;
            MessageId = messageId;
            Payload = payload;
            Action = action;
        }

        public OcppMessage(ArraySegment<byte> message)
        {
            JsonSerializerOptions options = GetSerializerOptions();

            var responseArray = JsonSerializer.Deserialize<object[]>(message, options);

            MessageType = (MessageType)int.Parse(responseArray[0].ToString());
            MessageId = Guid.Parse(responseArray[1].ToString());

            if (!Enum.TryParse<OcppAction>(responseArray[2].ToString(), out OcppAction action))
                action = OcppAction.Unknown;

            if (responseArray.Length == 4)
            {
                Action = action;
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
            if (Action == OcppAction.Unknown)
                jsonString = $"[{(int)MessageType},\"{MessageId}\",{Payload}]";
            else
                jsonString = $"[{(int)MessageType},\"{MessageId}\",\"{Action}\",{Payload}]";

            return jsonString;
        }

        public TResponse Parse<TResponse>(bool receiving = true)
            where TResponse : ResponseBase<TResponse>
        {
            JsonSerializerOptions options = GetSerializerOptions();

            TResponse response = JsonSerializer.Deserialize<TResponse>(Payload, options);
            response.MessageId = MessageId;

            Log(receiving);

            return response;
        }

        public TResponse Parse<TRequest, TResponse>(TRequest request, bool receiving = true)
            where TRequest : RequestBase<TRequest>
            where TResponse : ResponseBase<TRequest, TResponse>
        {
            JsonSerializerOptions options = GetSerializerOptions();

            TResponse response = JsonSerializer.Deserialize<TResponse>(Payload, options);
            response.MessageId = MessageId;
            response.Request = request;
            
            Log(receiving);

            return response;
        }

        public static OcppMessage Compose<T>(T action)
            where T : class, IAction
        {
            JsonSerializerOptions options = GetSerializerOptions();

            var message = new OcppMessage();

            switch (action)
            {
                case IRequest request:
                    message.MessageType = MessageType.CALL;
                    message.MessageId = Guid.NewGuid();
                    message.Action = Enum.Parse<OcppAction>(request.GetType().Name.Replace("Request", ""));
                    break;
                case IResponse response:
                    message.MessageType = MessageType.CALLRESULT;
                    message.MessageId = response.MessageId;
                    message.Action = OcppAction.Unknown;
                    break;
                default:
                    break;
            }

            message.Payload = JsonSerializer.Serialize<object>(action, options);
            return message;
        }

        internal static JsonSerializerOptions GetSerializerOptions()
        {
            var options = new JsonSerializerOptions
            {
                IgnoreNullValues = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                PropertyNameCaseInsensitive = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            };
            options.Converters.Add(new JsonStringEnumConverter());
            return options;
        }

        public void Log(bool receiving)
        {
            if (receiving)
                Console.ForegroundColor = ConsoleColor.Green;
            else
                Console.ForegroundColor = ConsoleColor.Gray;
            
            Console.WriteLine($"\nMessage {(receiving ? "received" : "sent")} : '{Action}{(receiving ? ".conf" : ".req")}'");

            if (logVerbose)
            {
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine($"MessageType: {MessageType}, Id: {MessageId}");
                if (Action != OcppAction.Unknown)
                    Console.WriteLine($"Action: {Action}");

                LogPayload();
            }

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine();

            Console.ResetColor();
        }

        private void LogPayload()
        {
            var options = new JsonWriterOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                Indented = true
            };

            var json = JsonDocument.Parse(Payload);

            Console.WriteLine("Payload:");
            using var writer = new Utf8JsonWriter(Console.OpenStandardOutput(), options: options);

            writer.WriteStartObject();
            foreach (JsonProperty property in json.RootElement.EnumerateObject())
            {
                property.WriteTo(writer);
            }
            writer.WriteEndObject();

            writer.Flush();

            Console.WriteLine();
        }
    }
}
