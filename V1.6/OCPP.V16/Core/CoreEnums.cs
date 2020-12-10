namespace OCPP.V16.Core
{
    public enum AuthorizationStatus
    {
        Accepted,
        Blocked,
        Expired,
        Invalid,
        ConcurrentTx,
    }

    public enum AvailabilityStatus
    {
        Accepted,
        Rejected,
        Scheduled,
    }

    public enum AvailabilityType
    {
        Inoperative,
        Operative,
    }

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
    public enum ChargePointStatus
    {
        Available,
        Preparing,
        Charging,
        SuspendedEVSE,
        SuspendedEV,
        Finishing,
        Reserved,
        Unavailable,
        Faulted,
    }

    public enum ChargingProfileKindType
    {
        Absolute,
        Recurring,
        Relative,
    }

    public enum ChargingProfilePurposeType
    {
        ChargePointMaxProfile,
        TxDefaultProfile,
        TxProfile,
    }

    public enum ChargingRateUnitType
    {
        A,
        W,
    }

    public enum ClearCacheStatus
    {
        Unknown,
        Accepted,
        Rejected,
    }

    public enum ConfigurationStatus
    {
        Accepted,
        Rejected,
        RebootRequired,
        NotSupported,
    }

    public enum DataTransferStatus
    {
        Accepted,
        Rejected,
        UnknownMessageId,
        UnknownVendorId,
    }

    public enum Location
    {
        Cable,
        EV,
        Inlet,
        Outlet,
        Body,
    }

    public enum Measurand
    {
        Energy_Active_Export_Register,
        Energy_Active_Import_Register,
        Energy_Reactive_Export_Register,
        Energy_Reactive_Import_Register,
        Energy_Active_Export_Interval,
        Energy_Active_Import_Interval,
        Energy_Reactive_Export_Interval,
        Energy_Reactive_Import_Interval,
        Power_Active_Export,
        Power_Active_Import,
        Power_Offered,
        Power_Reactive_Export,
        Power_Reactive_Import,
        Power_Factor,
        Current_Import,
        Current_Export,
        Current_Offered,
        Voltage,
        Frequency,
        Temperature,
        SoC,
        RPM,
    }

    public enum OcppAction
    {
        Unknown,
        BootNotification,
        Authorize,
        StartTransaction,
        StopTransaction,
        Heartbeat,
        MeterValues,
        ClearCache,
        DiagnosticsStatusNotification,
        FirmwareStatusNotification,
        StatusNotification,
        DataTransfer,
        TriggerMessage,
        UpdateFirmware,
        GetConfiguration,
        UnlockConnector,
        Reset,
        RemoteStartTransaction,
        RemoteStopTransaction,
        ChangeConfiguration,
        ChangeAvailability
    }

    public enum Phase
    {
        L1,
        L2,
        L3,
        N,
        L1N,
        L2N,
        L3N,
        L1L2,
        L2L3,
        L3L1,
    }

    public enum ReadingContext
    {
        Interruption_Begin,
        Interruption_End,
        Sample_Clock,
        Sample_Periodic,
        Transaction_Begin,
        Transaction_End,
        Trigger,
        Other,
    }

    public enum Reason
    {
        EmergencyStop,
        EVDisconnected,
        HardReset,
        Local,
        Other,
        PowerLoss,
        Reboot,
        Remote,
        SoftReset,
        UnlockCommand,
        DeAuthorized,
    }

    public enum RecurrencyKindType
    {
        Daily,
        Weekly,
    }

    public enum RegistrationStatus
    {
        Accepted,
        Pending,
        Rejected,
    }

    public enum RemoteStartStopStatus
    {
        Accepted,
        Rejected,
    }

    public enum ResetStatus
    {
        Accepted,
        Rejected,
    }

    public enum ResetType
    {
        Hard,
        Soft,
    }

    public enum UnitOfMeasure
    {
        Wh,
        KWh,
        Varh,
        Kvarh,
        W,
        KW,
        VA,
        KVA,
        Var,
        Kvar,
        A,
        V,
        K,
        Celcius,
        Celsius,
        Fahrenheit,
        Percent,
    }

    public enum UnlockStatus
    {
        Unlocked,
        UnlockFailed,
        NotSupported,
    }

    public enum ValueFormat
    {
        Raw,
        SignedData,
    }
}
