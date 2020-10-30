using System;

namespace OCCP.Core
{
    /// <summary>
    /// An abstract OCCP response base.
    /// </summary>
    public abstract class ResponseBase<TRequest, TResponse> : ResponseBase<TResponse> 
        where TRequest : class, IRequest 
        where TResponse : class, IResponse
    {
        /// <summary>
        /// The request leading to this response.
        /// </summary>
        public TRequest Request { get; }

        /// <summary>
        /// The runtime of the request.
        /// </summary>
        public TimeSpan Runtime { get; }

        /// <summary>
        /// Create a new generic response.
        /// </summary>
        /// <param name="Request">The request leading to this result.</param>
        /// <param name="Result">A generic result.</param>
        public ResponseBase(TRequest request, Result result) : base(result)
        {
            Request = request;
            Runtime = ResponseTimestamp - request.RequestTimestamp;
        }
    }


    /// <summary>
    /// An abstract OCPP response base.
    /// </summary>
    public abstract class ResponseBase<TResponse> : IResponse, IEquatable<TResponse> 
        where TResponse : class, IResponse
    {
        /// The machine-readable result code.
        /// </summary>
        public Result Result { get; }

        /// <summary>
        /// The timestamp of the response message creation.
        /// </summary>
        public DateTime ResponseTimestamp { get; }

        /// <summary>
        /// Create a new generic response.
        /// </summary>
        /// <param name="Result">A generic result.</param>
        public ResponseBase(Result result)
        {
            Result = result;
            ResponseTimestamp = DateTime.UtcNow;
        }

        #region Operator overloading

        #region Operator == (response1, response2)

        /// <summary>
        /// Compares two responses for equality.
        /// </summary>
        /// <param name="response1">response1</param>
        /// <param name="response2">response2</param>
        /// <returns>True if both match; False otherwise.</returns>
        public static bool operator ==(ResponseBase<TResponse> response1, ResponseBase<TResponse> response2)
        {

            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(response1, response2))
                return true;

            // If one is null, but not both, return false.
            if ((response1 is null) || (response2 is null))
                return false;

            return response1.Equals(response2);

        }

        #endregion

        #region Operator != (response1, response2)

        /// <summary>
        /// Compares two responses for inequality.
        /// </summary>
        /// <param name="response1">response1</param>
        /// <param name="response2">response2</param>
        /// <returns>False if both match; True otherwise.</returns>
        public static bool operator !=(ResponseBase<TResponse> response1, ResponseBase<TResponse> response2) => !(response1 == response2);

        #endregion

        #endregion

        #region IEquatable<ResponseBase> Members

        #region Equals(Object)

        /// <summary>
        /// Compares two instances of this object.
        /// </summary>
        /// <param name="obj">An object to compare with.</param>
        /// <returns>true|false</returns>
        public override bool Equals(object obj)
        {

            if (obj is null)
                return false;

            if (!(obj is ResponseBase<TResponse> response))
                return false;

            return Equals(response);

        }

        #endregion

        #region Equals(Response)

        /// <summary>
        /// Compares two responses for equality.
        /// </summary>
        /// <param name="response">A response to compare with.</param>
        /// <returns>True if both match; False otherwise.</returns>
        public bool Equals(ResponseBase<TResponse> response)
        {

            if (response is null)
                return false;

            return Result.Equals(response.Result);

        }

        #endregion

        #region IEquatable<Response> Members

        /// <summary>
        /// Compare two responses for equality.
        /// </summary>
        /// <param name="response">Another abstract generic response.</param>
        public abstract bool Equals(TResponse response);

        #endregion

        #endregion

        #region GetHashCode()

        /// <summary>
        /// Return the HashCode of this object.
        /// </summary>
        /// <returns>The HashCode of this object.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                return Result.GetHashCode();
            }
        }

        #endregion

        #region (override) ToString()

        /// <summary>
        /// Return a text representation of this object.
        /// </summary>
        public override string ToString() => Result.ToString();

        #endregion
    }
}
