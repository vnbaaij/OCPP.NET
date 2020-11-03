using System;

namespace OCPP.V16
{
    /// <summary>
    /// Common interface of a request message.
    /// </summary>
    public interface IRequest
    {
        /// <summary>
        /// The timestamp of the request message creation.
        /// </summary>
        DateTime  RequestTimestamp { get; }
    }
}
