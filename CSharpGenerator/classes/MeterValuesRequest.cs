





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
    
    /// <summary>Request_ Body
    /// urn:x-enexis:ecdm:uid:2:234744
    /// </summary>
    
    public partial class Anonymous 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Request_ Body. EVSEID. Numeric_ Identifier
        /// urn:x-enexis:ecdm:uid:1:571101
        /// This contains a number (&amp;gt;0) designating an EVSE of the Charging Station. ‘0’ (zero) is used to designate the main power meter.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("evseId", Required = Newtonsoft.Json.Required.Always)]
        public int EvseId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("meterValue", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<MeterValueType> MeterValue { get; set; } = new System.Collections.ObjectModel.Collection<MeterValueType>();
    
    
    }
}