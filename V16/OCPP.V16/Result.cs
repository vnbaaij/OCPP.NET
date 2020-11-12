using System;

namespace OCPP.V16

{

    /// <summary>
    /// A general OCPP result.
    /// </summary>
    public class Result : IEquatable<Result>
    {


        /// <summary>
        /// The machine-readable result code.
        /// </summary>
        public ResultCodes ResultCode { get; }

        /// <summary>
        /// A human-readable error description.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Create a new generic OCPP result.
        /// </summary>
        /// <param name="resultCode">The machine-readable result code.</param>
        /// <param name="description">A human-readable error description.</param>
        public Result(ResultCodes resultCode, string description = null)
        {
            ResultCode = resultCode;

            Description = !string.IsNullOrEmpty(description) ? description.Trim() : "";
        }

        /// <summary>
        /// Unknown result code.
        /// </summary>
        /// <param name="description">A human-readable error description.</param>
        public static Result Unknown(string description = null) => new Result(ResultCodes.Unknown, description);


        /// <summary>
        /// Data accepted and processed.
        /// </summary>
        /// <param name="description">A human-readable error description.</param>
        public static Result OK(string description = null) => new Result(ResultCodes.OK, description);


        /// <summary>
        /// Only part of the data was accepted.
        /// </summary>
        /// <param name="description">A human-readable error description.</param>
        public static Result Partly(string description = null) => new Result(ResultCodes.Partly, description);


        /// <summary>
        /// Wrong username and/or password.
        /// </summary>
        /// <param name="description">A human-readable error description.</param>
        public static Result NotAuthorized(string description = null) => new Result(ResultCodes.NotAuthorized, description);


        /// <summary>
        /// One or more ID (EVSE/Contract) were not valid for this user.
        /// </summary>
        /// <param name="description">A human-readable error description.</param>
        public static Result InvalidId(string description = null) => new Result(ResultCodes.InvalidId, description);


        /// <summary>
        /// Internal server error.
        /// </summary>
        /// <param name="description">A human-readable error description.</param>
        public static Result Server(string description = null) => new Result(ResultCodes.Server, description);


        /// <summary>
        /// Data has technical errors.
        /// </summary>
        /// <param name="description">A human-readable error description.</param>
        public static Result Format(string description = null) => new Result(ResultCodes.Format, description);


        #region Operator overloading

        #region Operator == (result1, result2)

        /// <summary>
        /// Compares two results for equality.
        /// </summary>
        /// <param name="result1">A result.</param>
        /// <param name="result2">Another result.</param>
        /// <returns>True if both match; False otherwise.</returns>
        public static bool operator ==(Result result1, Result result2)
        {

            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(result1, result2))
                return true;

            // If one is null, but not both, return false.
            if ((result1 is null) || (result2 is null))
                return false;

            return result1.Equals(result2);

        }

        #endregion

        #region Operator != (result1, result2)

        /// <summary>
        /// Compares two results for inequality.
        /// </summary>
        /// <param name="result1">A result.</param>
        /// <param name="result2">Another result.</param>
        /// <returns>False if both match; True otherwise.</returns>
        public static bool operator !=(Result result1, Result result2) => !(result1 == result2);

        #endregion

        #endregion

        #region IEquatable<Result> Members

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

            // Check if the given object is a result.
            var Result = obj as Result;
            if (Result is null)
                return false;

            return this.Equals(Result);

        }

        #endregion

        #region Equals(result)

        /// <summary>
        /// Compares two results for equality.
        /// </summary>
        /// <param name="result">An result to compare with.</param>
        /// <returns>True if both match; False otherwise.</returns>
        public bool Equals(Result result)
        {

            if (result is null)
                return false;

            return ResultCode.Equals(result.ResultCode) && Description.Equals(result.Description);

        }

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

                return ResultCode.GetHashCode() * 11 ^

                       (Description != null
                            ? Description.GetHashCode()
                            : 0);

            }
        }

        #endregion

        #region (override) ToString()

        /// <summary>
        /// Return a text representation of this object.
        /// </summary>
        public override string ToString() => ResultCode + (!string.IsNullOrEmpty(Description) ? " - " + Description : "");

        #endregion

    }

}
