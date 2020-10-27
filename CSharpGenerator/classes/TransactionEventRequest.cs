





namespace OCPP
{
    #pragma warning disable // Disable all warnings

    /// <summary>This class does not get 'AdditionalProperties = false' in the schema generation, so it can be extended with arbitrary JSON properties to allow adding custom data.</summary>
    
    public partial class CustomDataType 
    {
        //[Newtonsoft.Json.JsonProperty("vendorId", Required = Newtonsoft.Json.Required.Always)]
        public string VendorId { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        //[Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    /// <summary>Transaction. State. Transaction_ State_ Code
    /// urn:x-oca:ocpp:uid:1:569419
    /// Current charging state, is required when state
    /// has changed.
    /// </summary>
    
    public enum ChargingStateEnumType
    {
        
        Charging = 0,
    
        
        EVConnected = 1,
    
        
        SuspendedEV = 2,
    
        
        SuspendedEVSE = 3,
    
        
        Idle = 4,
    
    }
    
    /// <summary>Enumeration of possible idToken types.
    /// </summary>
    
    public enum IdTokenEnumType
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
    
    /// <summary>Sampled_ Value. Location. Location_ Code
    /// urn:x-oca:ocpp:uid:1:569265
    /// Indicates where the measured value has been sampled. Default =  "Outlet"
    /// 
    /// </summary>
    
    public enum LocationEnumType
    {
        
        Body = 0,
    
        
        Cable = 1,
    
        
        EV = 2,
    
        
        Inlet = 3,
    
        
        Outlet = 4,
    
    }
    
    /// <summary>Sampled_ Value. Measurand. Measurand_ Code
    /// urn:x-oca:ocpp:uid:1:569263
    /// Type of measurement. Default = "Energy.Active.Import.Register"
    /// </summary>
    
    public enum MeasurandEnumType
    {
        
        Current_Export = 0,
    
        
        Current_Import = 1,
    
        
        Current_Offered = 2,
    
        
        Energy_Active_Export_Register = 3,
    
        
        Energy_Active_Import_Register = 4,
    
        
        Energy_Reactive_Export_Register = 5,
    
        
        Energy_Reactive_Import_Register = 6,
    
        
        Energy_Active_Export_Interval = 7,
    
        
        Energy_Active_Import_Interval = 8,
    
        
        Energy_Active_Net = 9,
    
        
        Energy_Reactive_Export_Interval = 10,
    
        
        Energy_Reactive_Import_Interval = 11,
    
        
        Energy_Reactive_Net = 12,
    
        
        Energy_Apparent_Net = 13,
    
        
        Energy_Apparent_Import = 14,
    
        
        Energy_Apparent_Export = 15,
    
        
        Frequency = 16,
    
        
        Power_Active_Export = 17,
    
        
        Power_Active_Import = 18,
    
        
        Power_Factor = 19,
    
        
        Power_Offered = 20,
    
        
        Power_Reactive_Export = 21,
    
        
        Power_Reactive_Import = 22,
    
        
        SoC = 23,
    
        
        Voltage = 24,
    
    }
    
    /// <summary>Sampled_ Value. Phase. Phase_ Code
    /// urn:x-oca:ocpp:uid:1:569264
    /// Indicates how the measured value is to be interpreted. For instance between L1 and neutral (L1-N) Please note that not all values of phase are applicable to all Measurands. When phase is absent, the measured value is interpreted as an overall value.
    /// </summary>
    
    public enum PhaseEnumType
    {
        
        L1 = 0,
    
        
        L2 = 1,
    
        
        L3 = 2,
    
        
        N = 3,
    
        
        L1N = 4,
    
        
        L2N = 5,
    
        
        L3N = 6,
    
        
        L1L2 = 7,
    
        
        L2L3 = 8,
    
        
        L3L1 = 9,
    
    }
    
    /// <summary>Sampled_ Value. Context. Reading_ Context_ Code
    /// urn:x-oca:ocpp:uid:1:569261
    /// Type of detail value: start, end or sample. Default = "Sample.Periodic"
    /// </summary>
    
    public enum ReadingContextEnumType
    {
        
        Interruption_Begin = 0,
    
        
        Interruption_End = 1,
    
        
        Other = 2,
    
        
        Sample_Clock = 3,
    
        
        Sample_Periodic = 4,
    
        
        Transaction_Begin = 5,
    
        
        Transaction_End = 6,
    
        
        Trigger = 7,
    
    }
    
    /// <summary>Transaction. Stopped_ Reason. EOT_ Reason_ Code
    /// urn:x-oca:ocpp:uid:1:569413
    /// This contains the reason why the transaction was stopped. MAY only be omitted when Reason is "Local".
    /// </summary>
    
    public enum ReasonEnumType
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
    
    /// <summary>This contains the type of this event.
    /// The first TransactionEvent of a transaction SHALL contain: "Started" The last TransactionEvent of a transaction SHALL contain: "Ended" All others SHALL contain: "Updated"
    /// </summary>
    
    public enum TransactionEventEnumType
    {
        
        Ended = 0,
    
        
        Started = 1,
    
        
        Updated = 2,
    
    }
    
    /// <summary>Reason the Charging Station sends this message to the CSMS
    /// </summary>
    
    public enum TriggerReasonEnumType
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
    
    /// <summary>Contains a case insensitive identifier to use for the authorization and the type of authorization to support multiple forms of identifiers.
    /// </summary>
    
    public partial class AdditionalInfoType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>This field specifies the additional IdToken.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("additionalIdToken", Required = Newtonsoft.Json.Required.Always)]
        public string AdditionalIdToken { get; set; }
    
        /// <summary>This defines the type of the additionalIdToken. This is a custom type, so the implementation needs to be agreed upon by all involved parties.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        public string Type { get; set; }
    
    
    }
    
    /// <summary>EVSE
    /// urn:x-oca:ocpp:uid:2:233123
    /// Electric Vehicle Supply Equipment
    /// </summary>
    
    public partial class EVSEType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Identified_ Object. MRID. Numeric_ Identifier
        /// urn:x-enexis:ecdm:uid:1:569198
        /// EVSE Identifier. This contains a number (&amp;gt; 0) designating an EVSE of the Charging Station.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public int Id { get; set; }
    
        /// <summary>An id to designate a specific connector (on an EVSE) by connector index number.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("connectorId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ConnectorId { get; set; }
    
    
    }
    
    /// <summary>Contains a case insensitive identifier to use for the authorization and the type of authorization to support multiple forms of identifiers.
    /// </summary>
    
    public partial class IdTokenType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("additionalInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AdditionalInfoType> AdditionalInfo { get; set; }
    
        /// <summary>IdToken is case insensitive. Might hold the hidden id of an RFID tag, but can for example also contain a UUID.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("idToken", Required = Newtonsoft.Json.Required.Always)]
        public string IdToken { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public IdTokenEnumType Type { get; set; }
    
    
    }
    
    /// <summary>Meter_ Value
    /// urn:x-oca:ocpp:uid:2:233265
    /// Collection of one or more sampled values in MeterValuesRequest and TransactionEvent. All sampled values in a MeterValue are sampled at the same point in time.
    /// </summary>
    
    public partial class MeterValueType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("sampledValue", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<SampledValueType> SampledValue { get; set; } = new System.Collections.ObjectModel.Collection<SampledValueType>();
    
        /// <summary>Meter_ Value. Timestamp. Date_ Time
        /// urn:x-oca:ocpp:uid:1:569259
        /// Timestamp for measured value(s).
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset Timestamp { get; set; }
    
    
    }
    
    /// <summary>Sampled_ Value
    /// urn:x-oca:ocpp:uid:2:233266
    /// Single sampled value in MeterValues. Each value can be accompanied by optional fields.
    /// 
    /// To save on mobile data usage, default values of all of the optional fields are such that. The value without any additional fields will be interpreted, as a register reading of active import energy in Wh (Watt-hour) units.
    /// </summary>
    
    public partial class SampledValueType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Sampled_ Value. Value. Measure
        /// urn:x-oca:ocpp:uid:1:569260
        /// Indicates the measured value.
        /// 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Always)]
        public double Value { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("context", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ReadingContextEnumType Context { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("measurand", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MeasurandEnumType Measurand { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("phase", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PhaseEnumType Phase { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("location", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public LocationEnumType Location { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("signedMeterValue", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SignedMeterValueType SignedMeterValue { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("unitOfMeasure", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public UnitOfMeasureType UnitOfMeasure { get; set; }
    
    
    }
    
    /// <summary>Represent a signed version of the meter value.
    /// </summary>
    
    public partial class SignedMeterValueType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Base64 encoded, contains the signed data which might contain more then just the meter value. It can contain information like timestamps, reference to a customer etc.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("signedMeterData", Required = Newtonsoft.Json.Required.Always)]
        public string SignedMeterData { get; set; }
    
        /// <summary>Method used to create the digital signature.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("signingMethod", Required = Newtonsoft.Json.Required.Always)]
        public string SigningMethod { get; set; }
    
        /// <summary>Method used to encode the meter values before applying the digital signature algorithm.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("encodingMethod", Required = Newtonsoft.Json.Required.Always)]
        public string EncodingMethod { get; set; }
    
        /// <summary>Base64 encoded, sending depends on configuration variable _PublicKeyWithSignedMeterValue_.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("publicKey", Required = Newtonsoft.Json.Required.Always)]
        public string PublicKey { get; set; }
    
    
    }
    
    /// <summary>Transaction
    /// urn:x-oca:ocpp:uid:2:233318
    /// </summary>
    
    public partial class TransactionType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>This contains the Id of the transaction.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("transactionId", Required = Newtonsoft.Json.Required.Always)]
        public string TransactionId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("chargingState", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChargingStateEnumType ChargingState { get; set; }
    
        /// <summary>Transaction. Time_ Spent_ Charging. Elapsed_ Time
        /// urn:x-oca:ocpp:uid:1:569415
        /// Contains the total time that energy flowed from EVSE to EV during the transaction (in seconds). Note that timeSpentCharging is smaller or equal to the duration of the transaction.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("timeSpentCharging", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int TimeSpentCharging { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("stoppedReason", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ReasonEnumType StoppedReason { get; set; }
    
        /// <summary>The ID given to remote start request (&amp;lt;&amp;lt;requeststarttransactionrequest, RequestStartTransactionRequest&amp;gt;&amp;gt;. This enables to CSMS to match the started transaction to the given start request.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("remoteStartId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RemoteStartId { get; set; }
    
    
    }
    
    /// <summary>Represents a UnitOfMeasure with a multiplier
    /// </summary>
    
    public partial class UnitOfMeasureType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Unit of the value. Default = "Wh" if the (default) measurand is an "Energy" type.
        /// This field SHALL use a value from the list Standardized Units of Measurements in Part 2 Appendices. 
        /// If an applicable unit is available in that list, otherwise a "custom" unit might be used.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("unit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Unit { get; set; } = "Wh";
    
        /// <summary>Multiplier, this value represents the exponent to base 10. I.e. multiplier 3 means 10 raised to the 3rd power. Default is 0.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("multiplier", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Multiplier { get; set; } = 0;
    
    
    }
    
    
    public partial class Anonymous 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("eventType", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public TransactionEventEnumType EventType { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("meterValue", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<MeterValueType> MeterValue { get; set; }
    
        /// <summary>The date and time at which this transaction event occurred.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset Timestamp { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("triggerReason", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public TriggerReasonEnumType TriggerReason { get; set; }
    
        /// <summary>Incremental sequence number, helps with determining if all messages of a transaction have been received.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("seqNo", Required = Newtonsoft.Json.Required.Always)]
        public int SeqNo { get; set; }
    
        /// <summary>Indication that this transaction event happened when the Charging Station was offline. Default = false, meaning: the event occurred when the Charging Station was online.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("offline", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Offline { get; set; } = false;
    
        /// <summary>If the Charging Station is able to report the number of phases used, then it SHALL provide it. When omitted the CSMS may be able to determine the number of phases used via device management.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("numberOfPhasesUsed", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int NumberOfPhasesUsed { get; set; }
    
        /// <summary>The maximum current of the connected cable in Ampere (A).
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("cableMaxCurrent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int CableMaxCurrent { get; set; }
    
        /// <summary>This contains the Id of the reservation that terminates as a result of this transaction.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("reservationId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ReservationId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("transactionInfo", Required = Newtonsoft.Json.Required.Always)]
        public TransactionType TransactionInfo { get; set; } = new TransactionType();
    
        //[Newtonsoft.Json.JsonProperty("evse", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EVSEType Evse { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("idToken", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IdTokenType IdToken { get; set; }
    
    
    }
}