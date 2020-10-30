namespace OCPP.V201
{
    /// <summary>
    /// Enumeration of possible idToken types.
    /// </summary>

    public enum IdTokenType
    {
        Central = 0,
        EMAID = 1,
        ISO14443 = 2,
        ISO15693 = 3,
        KeyCode = 4,
        Local = 5,
        MacAddress = 6,
        NoAuthorization = 7,
    }
}