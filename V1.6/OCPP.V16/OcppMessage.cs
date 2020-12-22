using System;
using System.IO;
using System.Text;
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

        public OcppMessage(MessageType messageType, Guid messageId, string payload, OcppAction action = OcppAction.Unknown) //, string name = null)
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

        public TAction Parse<TAction>(bool receiving = true)
            where TAction : IAction
        {
            JsonSerializerOptions options = GetSerializerOptions();

            TAction response = JsonSerializer.Deserialize<TAction>(Payload, options);
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
                    message.MessageId = action.MessageId;
                    message.Action = Enum.Parse<OcppAction>(request.Name);
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
            JsonSerializerOptions options = new()
            {
                IgnoreNullValues = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                PropertyNameCaseInsensitive = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = true
            };
            options.Converters.Add(new JsonStringEnumConverter());
            return options;
        }

        public string Log(bool receiving, string responseAction = null)
        {
            StringBuilder output = new();

            //if (receiving)
            //    Console.ForegroundColor = ConsoleColor.Green;
            //else
            //    Console.ForegroundColor = ConsoleColor.Gray;

            output.Append($"Message {(receiving ? "received" : "sent")} : '{(Action is not OcppAction.Unknown ? Action : responseAction )}{(MessageType == MessageType.CALL ? ".req" : ".conf")}'\n");

            if (logVerbose)
            {
                 output.Append("----------------------------------------------------------------------\n");
                 output.Append($"MessageType: {MessageType}, Id: {MessageId}\n");
                if (Action != OcppAction.Unknown)
                     output.Append($"Action: {Action}\n");

                //output.Append(LogPayload());
                output.Append($"Payload:\n{Payload}\n");
            }

             output.Append("----------------------------------------------------------------------\n");

            return output.ToString();
            //Console.ResetColor();
        }
    }
}
