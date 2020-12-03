using System;
using System.Text.Json.Serialization;

namespace OCPP.V16
{
    /// <summary>
    /// An abstract OCPP request message base.
    /// </summary>
    public abstract record RequestBase<T> : IRequest 
        where T : class
    {
        /// <summary>
        /// The timestamp of the request message creation.
        /// </summary>
        [JsonIgnore]
        public DateTime RequestTimestamp { get; init; } = DateTime.UtcNow;
    }
}