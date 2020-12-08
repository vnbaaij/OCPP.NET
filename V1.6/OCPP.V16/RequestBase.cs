using System;
using System.Text.Json.Serialization;

namespace OCPP.V16
{
    /// <summary>
    /// An abstract OCPP request message base.
    /// </summary>
    public abstract record RequestBase<T> : IRequest 
        where T : class, IRequest
    {
        /// <summary>
        /// The timestamp of the request message creation.
        /// </summary>
        [JsonIgnore]
        public DateTime RequestTimestamp { get; init; } = DateTime.UtcNow;

        /// <summary>
        /// The Id of the message coming from the CSMS
        /// </summary>
        [JsonIgnore]
        public Guid MessageId { get; set; } = Guid.NewGuid();
    }
}