﻿using System;

namespace OCPP.V16
{
    /// <summary>
    /// Common interface of a response action.
    /// </summary>
    public interface IResponse : IAction
    {
        /// <summary>
        /// Timestamp of the response creation.
        /// </summary>
        DateTime ResponseTimestamp { get; }

        /// <summary>
        ///  The unique Id of each message send/received
        /// </summary>
        Guid MessageId { get; set; }
    }
}

