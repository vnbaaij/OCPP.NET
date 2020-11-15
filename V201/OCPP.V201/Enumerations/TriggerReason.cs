namespace OCPP.V201
{
    /// <summary>Reason the Charging Station sends this message to the CSMS
    /// </summary>

    public enum TriggerReason
    {

        Authorized = 0,
        CablePluggedIn = 1,
        ChargingRateChanged = 2,
        ChargingStateChanged = 3,
        Deauthorized = 4,
        EnergyLimitReached = 5,
        EVCommunicationLost = 6,
        EVConnectTimeout = 7,
        MeterValueClock = 8,
        MeterValuePeriodic = 9,
        TimeLimitReached = 10,
        Trigger = 11,
        UnlockCommand = 12,
        StopAuthorized = 13,
        EVDeparted = 14,
        EVDetected = 15,
        RemoteStop = 16,
        RemoteStart = 17,
        AbnormalCondition = 18,
        SignedDataReceived = 19,
        ResetCommand = 20,

    }
}