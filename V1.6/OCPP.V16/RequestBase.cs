﻿using System;
using System.Text.Json.Serialization;

namespace OCPP.V16
{
    /// <summary>
    /// An abstract OCPP request message base.
    /// </summary>
    public abstract class RequestBase<T> : IRequest /*, IEquatable<T>*/ 
        where T : class
    {
        /// <summary>
        /// The timestamp of the request message creation.
        /// </summary>
        [JsonIgnore]
        public DateTime RequestTimestamp { get; }

        /// <summary>
        /// Create a new generic OCPP request message.
        /// </summary>
        public RequestBase()
        {

            RequestTimestamp = DateTime.UtcNow;

        }

        /// <summary>
        /// Compare two requests for equality.
        /// </summary>
        /// <param name="Request">Another abstract OCPP base request.</param>
        //public abstract bool Equals(T Request);
    }
}