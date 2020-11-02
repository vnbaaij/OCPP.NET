namespace OCPP.Core
{
    /// <summary>
    /// Result and error codes for the class Result as return value for method calls.
    /// </summary>
    public enum ResultCodes
    {
        /// <summary>
        /// Unknown result code.
        /// </summary>
        Unknown,

        /// <summary>
        /// Data accepted and processed.
        /// </summary>
        OK,

        /// <summary>
        /// Only part of the data was accepted.
        /// </summary>
        Partly,

        /// <summary>
        /// Wrong username and/or password.
        /// </summary>
        NotAuthorized,

        /// <summary>
        /// One or more ID (EVSE/Contract) were not valid for this user.
        /// </summary>
        InvalidId,

        /// <summary>
        /// Internal server error.
        /// </summary>
        Server,

        /// <summary>
        /// Data has technical errors.
        /// </summary>
        Format
    }
}
