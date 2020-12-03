using OCPP.V16;
namespace OCPP.V16.Core
{
    public enum ChargePointErrorCode
    {
        ConnectorLockFailure,
        EVCommunicationError,
        GroundFailure,
        HighTemperature,
        InternalError,
        LocalListConflict,
        NoError,
        OtherError,
        OverCurrentFailure,
        PowerMeterFailure,
        PowerSwitchFailure,
        ReaderFailure,
        ResetFailure,
        UnderVoltage,
        OverVoltage,
        WeakSignal,
    }
}