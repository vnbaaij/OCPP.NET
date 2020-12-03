using System;

namespace OCPP.V16
{
    /// <summary>
    /// Common interface of a request action.
    /// </summary>
    public interface IRequest : IAction
    {
        /// <summary>
        /// Timestamp of the request creation.
        /// </summary>
        DateTime  RequestTimestamp { get; }
    }
}
