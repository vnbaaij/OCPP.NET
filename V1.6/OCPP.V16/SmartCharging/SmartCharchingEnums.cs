namespace OCPP.V16.SmartCharging
{
    public enum ChargingProfileStatus
    {
        Accepted,
        Rejected,
        NotSupported,
    }

    public enum ChargingRateUnitType
    {
        A,
        W,
    }

    public enum ClearChargingProfileStatus
    {
        Accepted,
        Unknown,
    }

    public enum GetCompositeScheduleStatus
    {
        Accepted,
        Rejected,
    }
}
