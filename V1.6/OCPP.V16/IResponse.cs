using System;

namespace OCPP.V16
{
    /// <summary>
    /// Common interface of a response message.
    /// </summary>
    public interface IResponse : IOperation
    {
        /// <summary>
        /// The timestamp of the response message creation.
        /// </summary>
        DateTime ResponseTimestamp { get; }

        /// <summary>
        ///  The unique Id of each message send/received
        /// </summary>
        Guid MessageId { get; set; }
    }
}

