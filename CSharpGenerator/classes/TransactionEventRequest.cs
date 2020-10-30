//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.2.2.0 (Newtonsoft.Json v9.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------

namespace OCPP.Generated
{
    #pragma warning disable // Disable all warnings

    /// <summary>This class does not get 'AdditionalProperties = false' in the schema generation, so it can be extended with arbitrary JSON properties to allow adding custom data.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class CustomDataType 
    {
        [Newtonsoft.Json.JsonProperty("vendorId", Required = Newtonsoft.Json.Required.Always)]
        public string VendorId { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
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
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum ChargingStateEnumType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Charging")]
        Charging = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"EVConnected")]
        EVConnected = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"SuspendedEV")]
        SuspendedEV = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"SuspendedEVSE")]
        SuspendedEVSE = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Idle")]
        Idle = 4,
    
    }
    
    /// <summary>Enumeration of possible idToken types.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum IdTokenEnumType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Central")]
        Central = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"eMAID")]
        EMAID = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ISO14443")]
        ISO14443 = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ISO15693")]
        ISO15693 = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"KeyCode")]
        KeyCode = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Local")]
        Local = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = @"MacAddress")]
        MacAddress = 6,
    
        [System.Runtime.Serialization.EnumMember(Value = @"NoAuthorization")]
        NoAuthorization = 7,
    
    }
    
    /// <summary>Sampled_ Value. Location. Location_ Code
    /// urn:x-oca:ocpp:uid:1:569265
    /// Indicates where the measured value has been sampled. Default =  "Outlet"
    /// 
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum LocationEnumType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Body")]
        Body = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Cable")]
        Cable = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"EV")]
        EV = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Inlet")]
        Inlet = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Outlet")]
        Outlet = 4,
    
    }
    
    /// <summary>Sampled_ Value. Measurand. Measurand_ Code
    /// urn:x-oca:ocpp:uid:1:569263
    /// Type of measurement. Default = "Energy.Active.Import.Register"
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum MeasurandEnumType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Current.Export")]
        Current_Export = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Current.Import")]
        Current_Import = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Current.Offered")]
        Current_Offered = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Energy.Active.Export.Register")]
        Energy_Active_Export_Register = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Energy.Active.Import.Register")]
        Energy_Active_Import_Register = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Energy.Reactive.Export.Register")]
        Energy_Reactive_Export_Register = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Energy.Reactive.Import.Register")]
        Energy_Reactive_Import_Register = 6,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Energy.Active.Export.Interval")]
        Energy_Active_Export_Interval = 7,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Energy.Active.Import.Interval")]
        Energy_Active_Import_Interval = 8,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Energy.Active.Net")]
        Energy_Active_Net = 9,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Energy.Reactive.Export.Interval")]
        Energy_Reactive_Export_Interval = 10,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Energy.Reactive.Import.Interval")]
        Energy_Reactive_Import_Interval = 11,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Energy.Reactive.Net")]
        Energy_Reactive_Net = 12,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Energy.Apparent.Net")]
        Energy_Apparent_Net = 13,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Energy.Apparent.Import")]
        Energy_Apparent_Import = 14,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Energy.Apparent.Export")]
        Energy_Apparent_Export = 15,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Frequency")]
        Frequency = 16,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Power.Active.Export")]
        Power_Active_Export = 17,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Power.Active.Import")]
        Power_Active_Import = 18,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Power.Factor")]
        Power_Factor = 19,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Power.Offered")]
        Power_Offered = 20,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Power.Reactive.Export")]
        Power_Reactive_Export = 21,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Power.Reactive.Import")]
        Power_Reactive_Import = 22,
    
        [System.Runtime.Serialization.EnumMember(Value = @"SoC")]
        SoC = 23,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Voltage")]
        Voltage = 24,
    
    }
    
    /// <summary>Sampled_ Value. Phase. Phase_ Code
    /// urn:x-oca:ocpp:uid:1:569264
    /// Indicates how the measured value is to be interpreted. For instance between L1 and neutral (L1-N) Please note that not all values of phase are applicable to all Measurands. When phase is absent, the measured value is interpreted as an overall value.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum PhaseEnumType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"L1")]
        L1 = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"L2")]
        L2 = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"L3")]
        L3 = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"N")]
        N = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"L1-N")]
        L1N = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"L2-N")]
        L2N = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = @"L3-N")]
        L3N = 6,
    
        [System.Runtime.Serialization.EnumMember(Value = @"L1-L2")]
        L1L2 = 7,
    
        [System.Runtime.Serialization.EnumMember(Value = @"L2-L3")]
        L2L3 = 8,
    
        [System.Runtime.Serialization.EnumMember(Value = @"L3-L1")]
        L3L1 = 9,
    
    }
    
    /// <summary>Sampled_ Value. Context. Reading_ Context_ Code
    /// urn:x-oca:ocpp:uid:1:569261
    /// Type of detail value: start, end or sample. Default = "Sample.Periodic"
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum ReadingContextEnumType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Interruption.Begin")]
        Interruption_Begin = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Interruption.End")]
        Interruption_End = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Other")]
        Other = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Sample.Clock")]
        Sample_Clock = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Sample.Periodic")]
        Sample_Periodic = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Transaction.Begin")]
        Transaction_Begin = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Transaction.End")]
        Transaction_End = 6,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Trigger")]
        Trigger = 7,
    
    }
    
    /// <summary>Transaction. Stopped_ Reason. EOT_ Reason_ Code
    /// urn:x-oca:ocpp:uid:1:569413
    /// This contains the reason why the transaction was stopped. MAY only be omitted when Reason is "Local".
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum ReasonEnumType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"DeAuthorized")]
        DeAuthorized = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"EmergencyStop")]
        EmergencyStop = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"EnergyLimitReached")]
        EnergyLimitReached = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"EVDisconnected")]
        EVDisconnected = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"GroundFault")]
        GroundFault = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ImmediateReset")]
        ImmediateReset = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Local")]
        Local = 6,
    
        [System.Runtime.Serialization.EnumMember(Value = @"LocalOutOfCredit")]
        LocalOutOfCredit = 7,
    
        [System.Runtime.Serialization.EnumMember(Value = @"MasterPass")]
        MasterPass = 8,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Other")]
        Other = 9,
    
        [System.Runtime.Serialization.EnumMember(Value = @"OvercurrentFault")]
        OvercurrentFault = 10,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PowerLoss")]
        PowerLoss = 11,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PowerQuality")]
        PowerQuality = 12,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Reboot")]
        Reboot = 13,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Remote")]
        Remote = 14,
    
        [System.Runtime.Serialization.EnumMember(Value = @"SOCLimitReached")]
        SOCLimitReached = 15,
    
        [System.Runtime.Serialization.EnumMember(Value = @"StoppedByEV")]
        StoppedByEV = 16,
    
        [System.Runtime.Serialization.EnumMember(Value = @"TimeLimitReached")]
        TimeLimitReached = 17,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Timeout")]
        Timeout = 18,
    
    }
    
    /// <summary>This contains the type of this event.
    /// The first TransactionEvent of a transaction SHALL contain: "Started" The last TransactionEvent of a transaction SHALL contain: "Ended" All others SHALL contain: "Updated"
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum TransactionEventEnumType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Ended")]
        Ended = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Started")]
        Started = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Updated")]
        Updated = 2,
    
    }
    
    /// <summary>Reason the Charging Station sends this message to the CSMS
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum TriggerReasonEnumType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Authorized")]
        Authorized = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"CablePluggedIn")]
        CablePluggedIn = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ChargingRateChanged")]
        ChargingRateChanged = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ChargingStateChanged")]
        ChargingStateChanged = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Deauthorized")]
        Deauthorized = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"EnergyLimitReached")]
        EnergyLimitReached = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = @"EVCommunicationLost")]
        EVCommunicationLost = 6,
    
        [System.Runtime.Serialization.EnumMember(Value = @"EVConnectTimeout")]
        EVConnectTimeout = 7,
    
        [System.Runtime.Serialization.EnumMember(Value = @"MeterValueClock")]
        MeterValueClock = 8,
    
        [System.Runtime.Serialization.EnumMember(Value = @"MeterValuePeriodic")]
        MeterValuePeriodic = 9,
    
        [System.Runtime.Serialization.EnumMember(Value = @"TimeLimitReached")]
        TimeLimitReached = 10,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Trigger")]
        Trigger = 11,
    
        [System.Runtime.Serialization.EnumMember(Value = @"UnlockCommand")]
        UnlockCommand = 12,
    
        [System.Runtime.Serialization.EnumMember(Value = @"StopAuthorized")]
        StopAuthorized = 13,
    
        [System.Runtime.Serialization.EnumMember(Value = @"EVDeparted")]
        EVDeparted = 14,
    
        [System.Runtime.Serialization.EnumMember(Value = @"EVDetected")]
        EVDetected = 15,
    
        [System.Runtime.Serialization.EnumMember(Value = @"RemoteStop")]
        RemoteStop = 16,
    
        [System.Runtime.Serialization.EnumMember(Value = @"RemoteStart")]
        RemoteStart = 17,
    
        [System.Runtime.Serialization.EnumMember(Value = @"AbnormalCondition")]
        AbnormalCondition = 18,
    
        [System.Runtime.Serialization.EnumMember(Value = @"SignedDataReceived")]
        SignedDataReceived = 19,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ResetCommand")]
        ResetCommand = 20,
    
    }
    
    /// <summary>Contains a case insensitive identifier to use for the authorization and the type of authorization to support multiple forms of identifiers.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class AdditionalInfoType 
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>This field specifies the additional IdToken.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("additionalIdToken", Required = Newtonsoft.Json.Required.Always)]
        public string AdditionalIdToken { get; set; }
    
        /// <summary>This defines the type of the additionalIdToken. This is a custom type, so the implementation needs to be agreed upon by all involved parties.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        public string Type { get; set; }
    
    
    }
    
    /// <summary>EVSE
    /// urn:x-oca:ocpp:uid:2:233123
    /// Electric Vehicle Supply Equipment
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class EVSEType 
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Identified_ Object. MRID. Numeric_ Identifier
        /// urn:x-enexis:ecdm:uid:1:569198
        /// EVSE Identifier. This contains a number (&amp;gt; 0) designating an EVSE of the Charging Station.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public int Id { get; set; }
    
        /// <summary>An id to designate a specific connector (on an EVSE) by connector index number.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("connectorId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ConnectorId { get; set; }
    
    
    }
    
    /// <summary>Contains a case insensitive identifier to use for the authorization and the type of authorization to support multiple forms of identifiers.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class IdTokenType 
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        [Newtonsoft.Json.JsonProperty("additionalInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AdditionalInfoType> AdditionalInfo { get; set; }
    
        /// <summary>IdToken is case insensitive. Might hold the hidden id of an RFID tag, but can for example also contain a UUID.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("idToken", Required = Newtonsoft.Json.Required.Always)]
        public string IdToken { get; set; }
    
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public IdTokenEnumType Type { get; set; }
    
    
    }
    
    /// <summary>Meter_ Value
    /// urn:x-oca:ocpp:uid:2:233265
    /// Collection of one or more sampled values in MeterValuesRequest and TransactionEvent. All sampled values in a MeterValue are sampled at the same point in time.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class MeterValueType 
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        [Newtonsoft.Json.JsonProperty("sampledValue", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<SampledValueType> SampledValue { get; set; } = new System.Collections.ObjectModel.Collection<SampledValueType>();
    
        /// <summary>Meter_ Value. Timestamp. Date_ Time
        /// urn:x-oca:ocpp:uid:1:569259
        /// Timestamp for measured value(s).
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset Timestamp { get; set; }
    
    
    }
    
    /// <summary>Sampled_ Value
    /// urn:x-oca:ocpp:uid:2:233266
    /// Single sampled value in MeterValues. Each value can be accompanied by optional fields.
    /// 
    /// To save on mobile data usage, default values of all of the optional fields are such that. The value without any additional fields will be interpreted, as a register reading of active import energy in Wh (Watt-hour) units.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class SampledValueType 
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Sampled_ Value. Value. Measure
        /// urn:x-oca:ocpp:uid:1:569260
        /// Indicates the measured value.
        /// 
        /// </summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Always)]
        public double Value { get; set; }
    
        [Newtonsoft.Json.JsonProperty("context", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ReadingContextEnumType Context { get; set; }
    
        [Newtonsoft.Json.JsonProperty("measurand", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MeasurandEnumType Measurand { get; set; }
    
        [Newtonsoft.Json.JsonProperty("phase", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PhaseEnumType Phase { get; set; }
    
        [Newtonsoft.Json.JsonProperty("location", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public LocationEnumType Location { get; set; }
    
        [Newtonsoft.Json.JsonProperty("signedMeterValue", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SignedMeterValueType SignedMeterValue { get; set; }
    
        [Newtonsoft.Json.JsonProperty("unitOfMeasure", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public UnitOfMeasureType UnitOfMeasure { get; set; }
    
    
    }
    
    /// <summary>Represent a signed version of the meter value.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class SignedMeterValueType 
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Base64 encoded, contains the signed data which might contain more then just the meter value. It can contain information like timestamps, reference to a customer etc.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("signedMeterData", Required = Newtonsoft.Json.Required.Always)]
        public string SignedMeterData { get; set; }
    
        /// <summary>Method used to create the digital signature.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("signingMethod", Required = Newtonsoft.Json.Required.Always)]
        public string SigningMethod { get; set; }
    
        /// <summary>Method used to encode the meter values before applying the digital signature algorithm.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("encodingMethod", Required = Newtonsoft.Json.Required.Always)]
        public string EncodingMethod { get; set; }
    
        /// <summary>Base64 encoded, sending depends on configuration variable _PublicKeyWithSignedMeterValue_.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("publicKey", Required = Newtonsoft.Json.Required.Always)]
        public string PublicKey { get; set; }
    
    
    }
    
    /// <summary>Transaction
    /// urn:x-oca:ocpp:uid:2:233318
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class TransactionType 
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>This contains the Id of the transaction.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transactionId", Required = Newtonsoft.Json.Required.Always)]
        public string TransactionId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("chargingState", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChargingStateEnumType ChargingState { get; set; }
    
        /// <summary>Transaction. Time_ Spent_ Charging. Elapsed_ Time
        /// urn:x-oca:ocpp:uid:1:569415
        /// Contains the total time that energy flowed from EVSE to EV during the transaction (in seconds). Note that timeSpentCharging is smaller or equal to the duration of the transaction.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timeSpentCharging", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int TimeSpentCharging { get; set; }
    
        [Newtonsoft.Json.JsonProperty("stoppedReason", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ReasonEnumType StoppedReason { get; set; }
    
        /// <summary>The ID given to remote start request (&amp;lt;&amp;lt;requeststarttransactionrequest, RequestStartTransactionRequest&amp;gt;&amp;gt;. This enables to CSMS to match the started transaction to the given start request.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remoteStartId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int RemoteStartId { get; set; }
    
    
    }
    
    /// <summary>Represents a UnitOfMeasure with a multiplier
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class UnitOfMeasureType 
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Unit of the value. Default = "Wh" if the (default) measurand is an "Energy" type.
        /// This field SHALL use a value from the list Standardized Units of Measurements in Part 2 Appendices. 
        /// If an applicable unit is available in that list, otherwise a "custom" unit might be used.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Unit { get; set; } = "Wh";
    
        /// <summary>Multiplier, this value represents the exponent to base 10. I.e. multiplier 3 means 10 raised to the 3rd power. Default is 0.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("multiplier", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Multiplier { get; set; } = 0;
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Anonymous 
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        [Newtonsoft.Json.JsonProperty("eventType", Required = Newtonsoft.Json.Required.Always)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public TransactionEventEnumType EventType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("meterValue", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<MeterValueType> MeterValue { get; set; }
    
        /// <summary>The date and time at which this transaction event occurred.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset Timestamp { get; set; }
    
        [Newtonsoft.Json.JsonProperty("triggerReason", Required = Newtonsoft.Json.Required.Always)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public TriggerReasonEnumType TriggerReason { get; set; }
    
        /// <summary>Incremental sequence number, helps with determining if all messages of a transaction have been received.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seqNo", Required = Newtonsoft.Json.Required.Always)]
        public int SeqNo { get; set; }
    
        /// <summary>Indication that this transaction event happened when the Charging Station was offline. Default = false, meaning: the event occurred when the Charging Station was online.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offline", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Offline { get; set; } = false;
    
        /// <summary>If the Charging Station is able to report the number of phases used, then it SHALL provide it. When omitted the CSMS may be able to determine the number of phases used via device management.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("numberOfPhasesUsed", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int NumberOfPhasesUsed { get; set; }
    
        /// <summary>The maximum current of the connected cable in Ampere (A).
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cableMaxCurrent", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int CableMaxCurrent { get; set; }
    
        /// <summary>This contains the Id of the reservation that terminates as a result of this transaction.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reservationId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ReservationId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("transactionInfo", Required = Newtonsoft.Json.Required.Always)]
        public TransactionType TransactionInfo { get; set; } = new TransactionType();
    
        [Newtonsoft.Json.JsonProperty("evse", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EVSEType Evse { get; set; }
    
        [Newtonsoft.Json.JsonProperty("idToken", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IdTokenType IdToken { get; set; }
    
    
    }
}