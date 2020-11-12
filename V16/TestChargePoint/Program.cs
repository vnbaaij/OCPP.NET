using System;
using System.IO;
using System.Net.WebSockets;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
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

        private static readonly object consoleLock = new object();
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

        private static byte[] ComposeMessage(IRequest request)
        {
            var options = new JsonSerializerOptions
            {
                IgnoreNullValues = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                //WriteIndented = true
            };

            string messageId = Guid.NewGuid().ToString("N");
            string action = request.GetType().Name.Replace("Request", "");
            string payload = JsonSerializer.Serialize<object>(request, options);

            string jsonString = $"[{(int)MessageType.CALL},\"{messageId}\",\"{action}\",{payload}]";

            return Encoding.UTF8.GetBytes(jsonString);
        }

        private static async Task Send(IRequest request)
        {
            if (webSocket.State == WebSocketState.Open)
            {
                var msg = ComposeMessage(request);

                await webSocket.SendAsync(msg, WebSocketMessageType.Text, true, CancellationToken.None);
                LogStatus(false, msg);
            }
        }

        private static async Task<TResponse> Receive<TRequest, TResponse>(TRequest request)
            where TRequest : RequestBase<TRequest>
            where TResponse : ResponseBase<TRequest, TResponse>

        {
            if (webSocket.State == WebSocketState.Open)
            {
                ArraySegment<byte> buffer = new ArraySegment<byte>(new byte[8192]);

                var responseMessage = new ResponseMessage();

                WebSocketReceiveResult result;
                //do
                //{
                    result = await webSocket.ReceiveAsync(buffer, CancellationToken.None);

                    if (result.MessageType == WebSocketMessageType.Close)
                        await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, CancellationToken.None);
                    else
                    {
                        responseMessage = ParseResponseMessage(buffer.Slice(0, result.Count));

                    }
                //} while (!result.EndOfMessage);


                var options = new JsonSerializerOptions
                {
                    IgnoreNullValues = true,
                    PropertyNameCaseInsensitive = true,
                    Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                };
                options.Converters.Add(new JsonStringEnumConverter());

                TResponse response = JsonSerializer.Deserialize<TResponse>(responseMessage.Payload, options);
                response.Request = request;
                return response;

            }
            return default;

        }

        private static ResponseMessage ParseResponseMessage(ArraySegment<byte> result)
        {
            LogStatus(true, result.ToArray());

            var doc = JsonDocument.Parse(result);

            var x = JsonSerializer.Deserialize<ResponseMessage>(result);

            return new ResponseMessage((MessageType)doc.RootElement[0].GetInt16(), doc.RootElement[1].GetString(), doc.RootElement[2].GetRawText());

        }

        private static void LogStatus(bool receiving, byte[] buffer)
        {

            lock (consoleLock)
            {
                if (receiving)
                    Console.ForegroundColor = ConsoleColor.Green ;
                else
                    Console.ForegroundColor = ConsoleColor.Gray;

                if (verbose)
                {

                    var doc = JsonDocument.Parse(buffer);

                    MessageType mt = (MessageType)doc.RootElement[0].GetInt16();

                    Console.WriteLine("----------------------------------------------------------------------");
                    Console.WriteLine($"MessageType: {mt}, Id: {doc.RootElement[1]}");
                    if (receiving)
                        LogPayload(doc.RootElement[2]);
                    else
                    {
                        Console.WriteLine($"Action: {doc.RootElement[2]}");
                        LogPayload(doc.RootElement[3]);
                    }
                }
                Console.WriteLine($"({buffer.Length} bytes total)");
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine();

                Console.ResetColor();
            }
        }

        private static void LogPayload(JsonElement payload)
        {
            var options = new JsonWriterOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                Indented = true
            };

            Console.WriteLine("Payload:");
            using var writer = new Utf8JsonWriter(Console.OpenStandardOutput(), options: options);

            writer.WriteStartObject();
            foreach (JsonProperty property in payload.EnumerateObject())
            {
                property.WriteTo(writer);
            }
            writer.WriteEndObject();

            writer.Flush();

            Console.WriteLine();
        }
    }
}
