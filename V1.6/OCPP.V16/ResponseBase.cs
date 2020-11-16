using System;
using System.Text.Json.Serialization;

namespace OCPP.V16
{
    /// <summary>
    /// An abstract OCCP response base.
    /// </summary>
    public abstract class ResponseBase<TRequest, TResponse> : ResponseBase<TResponse>
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
                if (_request != null)
                    Duration = ResponseTimestamp - _request.RequestTimestamp;
            }
        }

        /// <summary>
        /// The runtime of the request.
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

        protected ResponseBase() : base()
        {
        }
    }


    /// <summary>
    /// An abstract OCPP response base.
    /// </summary>
    public abstract class ResponseBase<TResponse> : IResponse /*, IEquatable<TResponse> */
        where TResponse : class, IResponse
    {
        /// <summary>
        /// The timestamp of the response message creation.
        /// </summary>
        [JsonIgnore]
        public DateTime ResponseTimestamp { get; }

        /// <summary>
        /// The Id of the message coming from the CSMS
        /// </summary>
        [JsonIgnore]
        public Guid MessageId { get; set; }

        /// <summary>
        /// Create a new generic response.
        /// </summary>
        public ResponseBase()
        {
            ResponseTimestamp = DateTime.UtcNow;
        }
    }
}
