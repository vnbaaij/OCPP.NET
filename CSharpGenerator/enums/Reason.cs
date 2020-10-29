namespace OCPP
{
    /// <summary>Transaction. Stopped_ Reason. EOT_ Reason_ Code
    /// urn:x-oca:ocpp:uid:1:569413
    /// This contains the reason why the transaction was stopped. MAY only be omitted when Reason is "Local".
    /// </summary>

    public enum Reason
    {

        DeAuthorized = 0,
        EmergencyStop = 1,
        EnergyLimitReached = 2,
        EVDisconnected = 3,
        GroundFault = 4,
        ImmediateReset = 5,
        Local = 6,
        LocalOutOfCredit = 7,
        MasterPass = 8,
        Other = 9,
        OvercurrentFault = 10,
        PowerLoss = 11,
        PowerQuality = 12,
        Reboot = 13,
        Remote = 14,
        SOCLimitReached = 15,
        StoppedByEV = 16,
        TimeLimitReached = 17,
        Timeout = 18,

    }
}