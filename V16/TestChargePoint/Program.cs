using System;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;


using OCPP.V16;
using OCPP.V16.Core;

namespace TestChargingStation
{
    class Program
    {
        private const string id = "CS_28_1";
        private const string csmsUrl = "ws://localhost:8180/steve/websocket/CentralSystemService/";

        private static readonly object consoleLock = new();
        private const bool verbose = true;

        private static ClientWebSocket webSocket = null;


        static async Task Main()
        {
            Console.WriteLine($"Running test for Ccharge P oint with id {id}");

            ConsoleKeyInfo cki;

            try
            {
                do
                {
                    MainMenu();
                    cki = Console.ReadKey(false); // show the key as you read it
                    switch (cki.KeyChar.ToString())
                    {
                        case "1":
                            await Connect();
                            break;
                        case "2":

                            break;
                    }

                } while (cki.Key != ConsoleKey.Escape);
                if (webSocket.State == WebSocketState.Open)
                {
                    await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Shutting down", CancellationToken.None);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex);
            }
            finally
            {
                if (webSocket != null)
                    webSocket.Dispose();
                Console.WriteLine();

                lock (consoleLock)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("WebSocket closed.");
                    Console.ResetColor();
                }
            }
        }

        private static void MainMenu()
        {
            //Console.Clear();
            Console.ResetColor();
            Console.WriteLine("Choose an action for this Charge Point:");
            Console.WriteLine("\t1 - Connect to Central System");
            Console.WriteLine("\t2 - Authorize");
            Console.WriteLine("\t3 - Start Transaction");
            Console.WriteLine("\t4 - Stop Transaction");
            Console.WriteLine("\t5 - Heartbeat");
            Console.WriteLine("\t6 - Send Meter Values");
            Console.WriteLine("\t7 - Status Notification");
            Console.WriteLine("\t8 - Data Transfer");
            Console.WriteLine("\tESC - Exit");
            Console.Write("\r\nSelect an action: ");
        }

        public static async Task Connect()
        {

            webSocket = new ClientWebSocket();
            webSocket.Options.AddSubProtocol("ocpp2.0.1");
            webSocket.Options.AddSubProtocol("ocpp1.6");
            await webSocket.ConnectAsync(new Uri(csmsUrl + id), CancellationToken.None);
            Console.WriteLine("\r\nConnected to Central System!");

            var request = new BootNotificationRequest
            {
                ChargePointVendor = "Baaijte",
                ChargePointModel = "QuickCharger 11+",
                ChargePointSerialNumber = "bqc.001.20.1",
                ChargeBoxSerialNumber = "bqc.001.20.1.01",
                FirmwareVersion = "3.11.20",
                MeterType = "Landis+Gyr E350",
                MeterSerialNumber = "4530303035303031363935303633303135"
            };

            await Send(request);


            var result = await Receive<BootNotificationRequest, BootNotificationResponse>(request);
        }

        private static OcppMessage ComposeMessage(IRequest request)
        {
            var options = new JsonSerializerOptions
            {
                IgnoreNullValues = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                //WriteIndented = true
            };

            var message = new OcppMessage()
            {
                MessageType = MessageType.CALL,
                RequestId = Guid.NewGuid().ToString("N"),
                Action = request.GetType().Name.Replace("Request", ""),
                Payload = JsonSerializer.Serialize<object>(request, options)
            };

            //string messageId = Guid.NewGuid().ToString("N");
            //string action = request.GetType().Name.Replace("Request", "");
            //string payload = JsonSerializer.Serialize<object>(request, options);

            //string jsonString = $"[{(int)MessageType.CALL},\"{messageId}\",\"{action}\",{payload}]";

            return message;
        }

        private static async Task Send(IRequest request)
        {
            if (webSocket.State == WebSocketState.Open)
            {
                var message = ComposeMessage(request);

                await webSocket.SendAsync(Encoding.UTF8.GetBytes(message.ToString()), WebSocketMessageType.Text, true, CancellationToken.None);
                LogStatus(false, message);
            }
        }

        private static async Task<TResponse> Receive<TRequest, TResponse>(TRequest request)
            where TRequest : RequestBase<TRequest>
            where TResponse : ResponseBase<TRequest, TResponse>

        {
            if (webSocket.State == WebSocketState.Open)
            {
                byte[] buffer = new byte[8192];

                string payload = null;

                WebSocketReceiveResult result;
                //do
                //{
                result = await webSocket.ReceiveAsync(buffer, CancellationToken.None);

                if (result.MessageType == WebSocketMessageType.Close)
                    await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, CancellationToken.None);
                else
                {
                    var responseMessage = new OcppMessage(buffer.Take(result.Count).ToArray());
                    LogStatus(true, responseMessage);
                    payload = responseMessage.Payload;

                }
                //} while (!result.EndOfMessage);


                var options = new JsonSerializerOptions
                {
                    IgnoreNullValues = true,
                    PropertyNameCaseInsensitive = true,
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                };
                options.Converters.Add(new JsonStringEnumConverter());

                TResponse response = JsonSerializer.Deserialize<TResponse>(payload, options);
                response.Request = request;
                return response;

            }
            return default;

        }

        private static void LogStatus(bool receiving, OcppMessage ocppMessage)
        {

            lock (consoleLock)
            {
                if (receiving)
                    Console.ForegroundColor = ConsoleColor.Green;
                else
                    Console.ForegroundColor = ConsoleColor.Gray;

                if (verbose)
                {

                    //var doc = JsonDocument.Parse(buffer);

                    MessageType mt = ocppMessage.MessageType;

                    Console.WriteLine("----------------------------------------------------------------------");
                    Console.WriteLine($"MessageType: {ocppMessage.MessageType}, Id: {ocppMessage.RequestId}");
                    if (!receiving)
                        Console.WriteLine($"Action: {ocppMessage.Action}");

                    LogPayload(ocppMessage.Payload);

                }
                //Console.WriteLine($"({buffer.Length} bytes total)");
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine();

                Console.ResetColor();
            }
        }

        private static void LogPayload(string payload)
        {
            var options = new JsonWriterOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                Indented = true
            };

            var json = JsonDocument.Parse(payload);

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
