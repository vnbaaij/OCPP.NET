using OCPP.V16;
namespace OCPP.V16.Core
{
    public enum ReadingContext
    {
        Interruption_Begin,
        Interruption_End,
        Sample_Clock,
        Sample_Periodic,
        Transaction_Begin,
        Transaction_End,
        Trigger,
        Other,
    }
}