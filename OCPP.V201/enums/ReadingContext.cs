namespace OCPP
{
    /// <summary>Sampled_ Value. Context. Reading_ Context_ Code
    /// urn:x-oca:ocpp:uid:1:569261
    /// Type of detail value: start, end or sample. Default = "Sample.Periodic"
    /// </summary>

    public enum ReadingContext
    {

        Interruption_Begin = 0,
        Interruption_End = 1,
        Other = 2,
        Sample_Clock = 3,
        Sample_Periodic = 4,
        Transaction_Begin = 5,
        Transaction_End = 6,
        Trigger = 7,

    }
}