﻿using System;

namespace OCPP.V201.Core
{
    /// <summary>
    /// Common interface of a response message.
    /// </summary>
    public interface IResponse
    {
        /// <summary>
        /// The machine-readable result code.
        /// </summary>
        Result Result { get; }

        /// <summary>
        /// The timestamp of the response message creation.
        /// </summary>
        DateTime ResponseTimestamp { get; }
    }
}
