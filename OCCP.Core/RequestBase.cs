using System;

namespace OCCP.Core
{
    /// <summary>
    /// An abstract OCPP request message base.
    /// </summary>
    public abstract class RequestBase<T> : IRequest, IEquatable<T> where T : class

    {

        #region Properties

        /// <summary>
        /// The timestamp of the request message creation.
        /// </summary>
        public DateTime RequestTimestamp { get; }

        #endregion

        #region Constructor(s)

        /// <summary>
        /// Create a new generic OCPP request message.
        /// </summary>
        public RequestBase()
        {

            RequestTimestamp = DateTime.UtcNow;

        }

        #endregion


        #region IEquatable<RequestBase> Members

        /// <summary>
        /// Compare two requests for equality.
        /// </summary>
        /// <param name="Request">Another abstract OCPP base request.</param>
        public abstract bool Equals(T Request);

        #endregion

    }

}
