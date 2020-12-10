using System;
using TestChargePoint;

ConsoleKeyInfo cki;

Console.WriteLine($"Charge Point operations tester");

try
{
    do
    {
        Console.Clear();
        await ChargePoint.Run();
        Console.WriteLine("\nPress R to re-connect or any other key to exit.");
        cki = Console.ReadKey();
    } while (cki.KeyChar.ToString() == "r");
}
catch (OperationCanceledException)
{
    // normal upon task/token cancellation, disregard
}
catch (Exception ex)
{
    Console.WriteLine($"Exception: {ex}");
}
finally
{
    Console.WriteLine();


    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("WebSocket closed.");
    Console.ResetColor();
}