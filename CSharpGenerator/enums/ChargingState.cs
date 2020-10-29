namespace OCPP
{
    /// <summary>Transaction. State. Transaction_ State_ Code
    /// urn:x-oca:ocpp:uid:1:569419
    /// Current charging state, is required when state
    /// has changed.
    /// </summary>

    public enum ChargingState
    {

        Charging = 0,
        EVConnected = 1,
        SuspendedEV = 2,
        SuspendedEVSE = 3,
        Idle = 4,

    }
}