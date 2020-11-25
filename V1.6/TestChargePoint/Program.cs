using Spectre.Console;
using System;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;


namespace TestChargePoint
{
    class Program
    {
        private const string id = "CS_28_1";
        private const string csmsUrl = "ws://localhost:8180/steve/websocket/CentralSystemService/";

        private static readonly object consoleLock = new();
        public static CancellationTokenSource _waitloopTokenSource;


        private static void ShowMenu()
        {
            //Console.Clear();
            lock (consoleLock)
            {
                Console.ResetColor();
                Console.WriteLine("\nChoose an action for this Charge Point:");
                Console.WriteLine("\t1 - Boot");
                Console.WriteLine("\t2 - Authorize");
                Console.WriteLine("\t3 - Start Transaction");
                Console.WriteLine("\t4 - Stop Transaction");
                Console.WriteLine("\t5 - Heartbeat");
                Console.WriteLine("\t6 - Send Meter Values");
                Console.WriteLine("\t7 - Diagnostics Status Notification");
                Console.WriteLine("\t8 - Data Transfer");
                Console.WriteLine("\tr - Check if message received from Central System (waits 10 seconds)");
                Console.WriteLine("\tESC - Exit");
                Console.Write("\r\nSelect an action: ");
            }
        }

        static async Task Start()
        {

            try
            {
                //_waitloopTokenSource = new CancellationTokenSource();
                await ChargePoint.Start(csmsUrl + id);
                await HandleMenu();
                await ChargePoint.Stop();
            }
            catch (OperationCanceledException)
            {
                // normal upon task/token cancellation, disregard
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Exception: {0}", ex);
                AnsiConsole.WriteException(ex, new ExceptionSettings
                {
                    Format = ExceptionFormats.ShortenEverything | ExceptionFormats.ShowLinks,
                    Style = new ExceptionStyle
                    {
                        Exception = new Style().Foreground(Color.Grey),
                        Message = new Style().Foreground(Color.White),
                        NonEmphasized = new Style().Foreground(Color.Cornsilk1),
                        Parenthesis = new Style().Foreground(Color.Cornsilk1),
                        Method = new Style().Foreground(Color.Red),
                        ParameterName = new Style().Foreground(Color.Cornsilk1),
                        ParameterType = new Style().Foreground(Color.Red),
                        Path = new Style().Foreground(Color.Red),
                        LineNumber = new Style().Foreground(Color.Cornsilk1),
                    }
                });
            }
            finally
            {
                Console.WriteLine();

                lock (consoleLock)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("WebSocket closed.");
                    Console.ResetColor();
                }
            }
        }

        public static async Task HandleMenu()
        {
            ConsoleKeyInfo cki;
            bool running = true;

            do
            {
                try
                {
                    _waitloopTokenSource = new();
                    ShowMenu();
                    cki = Console.ReadKey();

                    ChargePoint.QueueOperation(cki.KeyChar.ToString());

                    if (cki.Key == ConsoleKey.Escape)
                    {
                        running = false;
                        _waitloopTokenSource.Cancel();
                    }
                    await Task.Run(() => Task.Delay(10000, _waitloopTokenSource.Token));

                    
                }
                catch (OperationCanceledException)
                {

                }
            } while ( running && ChargePoint.State == WebSocketState.Open);
            //return cki;
        }

        static async Task Main()
        {
            ConsoleKeyInfo cki;

            Console.WriteLine($"Charge Point ({id}) operations tester");

            do
            {
                Console.Clear();
                await Start();
                Console.WriteLine("\nPress R to re-connect or any other key to exit.");
                cki = Console.ReadKey();
            } while (cki.KeyChar.ToString() == "r");
        }
    }
}
