namespace OCPP.V16
{
    /// <summary>
    /// Identifies the type of message that is transmitted
    /// </summary>
    public enum MessageType
    {
        /// <summary>
        /// Direction = Client-to-server
        /// </summary>
        CALL = 2,           

        /// <summary>
        /// Direction = Sever-to-Client
        /// </summary>
        CALLRESULT = 3,

        /// <summary>
        /// Direction = Server-to-Client
        /// </summary>
        CALLERROR = 4,
    }
}
