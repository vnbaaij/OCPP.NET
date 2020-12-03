﻿using System;

namespace OCPP.V16
{
    /// <summary>
    /// Common interface of a request action.
    /// </summary>
    public interface IRequest : IAction
    {
        /// <summary>
        /// The timestamp of the request message creation.
        /// </summary>
        DateTime  RequestTimestamp { get; }
    }
}
