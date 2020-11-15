using System;

namespace OCPP.V16
{
    /// <summary>
    /// An abstract OCCP response base.
    /// </summary>
    public abstract class ResponseBase<TRequest, TResponse> : ResponseBase<TResponse>
        where TRequest : RequestBase<TRequest>
        where TResponse : class, IResponse
    {
        private TRequest request;
        /// <summary>
        /// The request leading to this response.
        /// </summary>
        public TRequest Request
        {
            get { return request; }
            set
            {
                request = value;
                if (request != null)
                    Runtime = ResponseTimestamp - request.RequestTimestamp;
            }
        }

        /// <summary>
        /// The runtime of the request.
        /// </summary>
        public TimeSpan Runtime { get; set; }

        /// <summary>
        /// Create a new generic response.
        /// </summary>
        /// <param name="Request">The request leading to this result.</param>
        public ResponseBase(TRequest request) : base()
        {
            Request = request;
            if (request != null)
                Runtime = ResponseTimestamp - request.RequestTimestamp;
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
        public DateTime ResponseTimestamp { get; }

        /// <summary>
        /// Create a new generic response.
        /// </summary>
        public ResponseBase()
        {
            ResponseTimestamp = DateTime.UtcNow;
        }
    }
}
