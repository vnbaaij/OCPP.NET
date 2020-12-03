using System;
using System.Text.Json.Serialization;

namespace OCPP.V16
{
    /// <summary>
    /// An abstract OCCP response base.
    /// </summary>
    public abstract record ResponseBase<TRequest, TResponse> : ResponseBase<TResponse>
        where TRequest : RequestBase<TRequest>
        where TResponse : class, IResponse
    {
        private TRequest _request;
        
        /// <summary>
        /// The request leading to this response.
        /// </summary>
        public TRequest Request
        {
            get { return _request; }
            set
            {
                _request = value;
                if (_request != null) Duration = ResponseTimestamp - _request.RequestTimestamp;
            }
        }

        /// <summary>
        /// The time taken by request and response.
        /// </summary>
        [JsonIgnore]

        public TimeSpan Duration { get; set; }

        /// <summary>
        /// Create a new generic response.
        /// </summary>
        /// <param name="Request">The request leading to this result.</param>
        public ResponseBase(TRequest request) : base()
        {
            Request = request;
            if (request != null)
                Duration = ResponseTimestamp - request.RequestTimestamp;
        }
    }


    /// <summary>
    /// An abstract OCPP response base.
    /// </summary>
    public abstract record ResponseBase<TResponse> : IResponse /*, IEquatable<TResponse> */
        where TResponse : class, IResponse
    {
        /// <summary>
        /// The timestamp of the response message creation.
        /// </summary>
        [JsonIgnore]
        public DateTime ResponseTimestamp { get; init; } = DateTime.UtcNow;

        /// <summary>
        /// The Id of the message coming from the CSMS
        /// </summary>
        [JsonIgnore]
        public Guid MessageId { get; set; }
    }
}
