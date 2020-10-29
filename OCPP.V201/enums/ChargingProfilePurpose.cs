namespace OCPP
{
    /// <summary>Charging_ Profile. Charging_ Profile_ Purpose. Charging_ Profile_ Purpose_ Code
    /// urn:x-oca:ocpp:uid:1:569231
    /// Specifies to purpose of the charging profiles that will be cleared, if they meet the other criteria in the request.
    /// </summary>

    public enum ChargingProfilePurpose
    {
        
        ChargingStationExternalConstraints = 0,
        ChargingStationMaxProfile = 1,
        TxDefaultProfile = 2,
        TxProfile = 3,
    
    }
}