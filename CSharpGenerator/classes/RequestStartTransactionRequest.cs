





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
    
    /// <summary>Charging_ Profile. Charging_ Profile_ Kind. Charging_ Profile_ Kind_ Code
    /// urn:x-oca:ocpp:uid:1:569232
    /// Indicates the kind of schedule.
    /// </summary>
    
    public enum ChargingProfileKindEnumType
    {
        
        Absolute = 0,
    
        
        Recurring = 1,
    
        
        Relative = 2,
    
    }
    
    /// <summary>Charging_ Profile. Charging_ Profile_ Purpose. Charging_ Profile_ Purpose_ Code
    /// urn:x-oca:ocpp:uid:1:569231
    /// Defines the purpose of the schedule transferred by this profile
    /// </summary>
    
    public enum ChargingProfilePurposeEnumType
    {
        
        ChargingStationExternalConstraints = 0,
    
        
        ChargingStationMaxProfile = 1,
    
        
        TxDefaultProfile = 2,
    
        
        TxProfile = 3,
    
    }
    
    /// <summary>Charging_ Schedule. Charging_ Rate_ Unit. Charging_ Rate_ Unit_ Code
    /// urn:x-oca:ocpp:uid:1:569238
    /// The unit of measure Limit is expressed in.
    /// </summary>
    
    public enum ChargingRateUnitEnumType
    {
        
        W = 0,
    
        
        A = 1,
    
    }
    
    /// <summary>Cost. Cost_ Kind. Cost_ Kind_ Code
    /// urn:x-oca:ocpp:uid:1:569243
    /// The kind of cost referred to in the message element amount
    /// </summary>
    
    public enum CostKindEnumType
    {
        
        CarbonDioxideEmission = 0,
    
        
        RelativePricePercentage = 1,
    
        
        RenewableGenerationPercentage = 2,
    
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
    
    /// <summary>Charging_ Profile. Recurrency_ Kind. Recurrency_ Kind_ Code
    /// urn:x-oca:ocpp:uid:1:569233
    /// Indicates the start point of a recurrence.
    /// </summary>
    
    public enum RecurrencyKindEnumType
    {
        
        Daily = 0,
    
        
        Weekly = 1,
    
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
    
    /// <summary>Charging_ Profile
    /// urn:x-oca:ocpp:uid:2:233255
    /// A ChargingProfile consists of ChargingSchedule, describing the amount of power or current that can be delivered per time interval.
    /// </summary>
    
    public partial class ChargingProfileType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Identified_ Object. MRID. Numeric_ Identifier
        /// urn:x-enexis:ecdm:uid:1:569198
        /// Id of ChargingProfile.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public int Id { get; set; }
    
        /// <summary>Charging_ Profile. Stack_ Level. Counter
        /// urn:x-oca:ocpp:uid:1:569230
        /// Value determining level in hierarchy stack of profiles. Higher values have precedence over lower values. Lowest level is 0.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("stackLevel", Required = Newtonsoft.Json.Required.Always)]
        public int StackLevel { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("chargingProfilePurpose", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChargingProfilePurposeEnumType ChargingProfilePurpose { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("chargingProfileKind", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChargingProfileKindEnumType ChargingProfileKind { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("recurrencyKind", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RecurrencyKindEnumType RecurrencyKind { get; set; }
    
        /// <summary>Charging_ Profile. Valid_ From. Date_ Time
        /// urn:x-oca:ocpp:uid:1:569234
        /// Point in time at which the profile starts to be valid. If absent, the profile is valid as soon as it is received by the Charging Station.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("validFrom", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ValidFrom { get; set; }
    
        /// <summary>Charging_ Profile. Valid_ To. Date_ Time
        /// urn:x-oca:ocpp:uid:1:569235
        /// Point in time at which the profile stops to be valid. If absent, the profile is valid until it is replaced by another profile.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("validTo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ValidTo { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("chargingSchedule", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<ChargingScheduleType> ChargingSchedule { get; set; } = new System.Collections.ObjectModel.Collection<ChargingScheduleType>();
    
        /// <summary>SHALL only be included if ChargingProfilePurpose is set to TxProfile. The transactionId is used to match the profile to a specific transaction.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("transactionId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TransactionId { get; set; }
    
    
    }
    
    /// <summary>Charging_ Schedule_ Period
    /// urn:x-oca:ocpp:uid:2:233257
    /// Charging schedule period structure defines a time period in a charging schedule.
    /// </summary>
    
    public partial class ChargingSchedulePeriodType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Charging_ Schedule_ Period. Start_ Period. Elapsed_ Time
        /// urn:x-oca:ocpp:uid:1:569240
        /// Start of the period, in seconds from the start of schedule. The value of StartPeriod also defines the stop time of the previous period.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("startPeriod", Required = Newtonsoft.Json.Required.Always)]
        public int StartPeriod { get; set; }
    
        /// <summary>Charging_ Schedule_ Period. Limit. Measure
        /// urn:x-oca:ocpp:uid:1:569241
        /// Charging rate limit during the schedule period, in the applicable chargingRateUnit, for example in Amperes (A) or Watts (W). Accepts at most one digit fraction (e.g. 8.1).
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("limit", Required = Newtonsoft.Json.Required.Always)]
        public double Limit { get; set; }
    
        /// <summary>Charging_ Schedule_ Period. Number_ Phases. Counter
        /// urn:x-oca:ocpp:uid:1:569242
        /// The number of phases that can be used for charging. If a number of phases is needed, numberPhases=3 will be assumed unless another number is given.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("numberPhases", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int NumberPhases { get; set; }
    
        /// <summary>Values: 1..3, Used if numberPhases=1 and if the EVSE is capable of switching the phase connected to the EV, i.e. ACPhaseSwitchingSupported is defined and true. It’s not allowed unless both conditions above are true. If both conditions are true, and phaseToUse is omitted, the Charging Station / EVSE will make the selection on its own.
        /// 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("phaseToUse", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int PhaseToUse { get; set; }
    
    
    }
    
    /// <summary>Charging_ Schedule
    /// urn:x-oca:ocpp:uid:2:233256
    /// Charging schedule structure defines a list of charging periods, as used in: GetCompositeSchedule.conf and ChargingProfile. 
    /// </summary>
    
    public partial class ChargingScheduleType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Identifies the ChargingSchedule.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public int Id { get; set; }
    
        /// <summary>Charging_ Schedule. Start_ Schedule. Date_ Time
        /// urn:x-oca:ocpp:uid:1:569237
        /// Starting point of an absolute schedule. If absent the schedule will be relative to start of charging.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("startSchedule", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset StartSchedule { get; set; }
    
        /// <summary>Charging_ Schedule. Duration. Elapsed_ Time
        /// urn:x-oca:ocpp:uid:1:569236
        /// Duration of the charging schedule in seconds. If the duration is left empty, the last period will continue indefinitely or until end of the transaction if chargingProfilePurpose = TxProfile.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("duration", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Duration { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("chargingRateUnit", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChargingRateUnitEnumType ChargingRateUnit { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("chargingSchedulePeriod", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<ChargingSchedulePeriodType> ChargingSchedulePeriod { get; set; } = new System.Collections.ObjectModel.Collection<ChargingSchedulePeriodType>();
    
        /// <summary>Charging_ Schedule. Min_ Charging_ Rate. Numeric
        /// urn:x-oca:ocpp:uid:1:569239
        /// Minimum charging rate supported by the EV. The unit of measure is defined by the chargingRateUnit. This parameter is intended to be used by a local smart charging algorithm to optimize the power allocation for in the case a charging process is inefficient at lower charging rates. Accepts at most one digit fraction (e.g. 8.1)
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("minChargingRate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double MinChargingRate { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("salesTariff", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SalesTariffType SalesTariff { get; set; }
    
    
    }
    
    /// <summary>Consumption_ Cost
    /// urn:x-oca:ocpp:uid:2:233259
    /// </summary>
    
    public partial class ConsumptionCostType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Consumption_ Cost. Start_ Value. Numeric
        /// urn:x-oca:ocpp:uid:1:569246
        /// The lowest level of consumption that defines the starting point of this consumption block. The block interval extends to the start of the next interval.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("startValue", Required = Newtonsoft.Json.Required.Always)]
        public double StartValue { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("cost", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<CostType> Cost { get; set; } = new System.Collections.ObjectModel.Collection<CostType>();
    
    
    }
    
    /// <summary>Cost
    /// urn:x-oca:ocpp:uid:2:233258
    /// </summary>
    
    public partial class CostType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("costKind", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CostKindEnumType CostKind { get; set; }
    
        /// <summary>Cost. Amount. Amount
        /// urn:x-oca:ocpp:uid:1:569244
        /// The estimated or actual cost per kWh
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Always)]
        public int Amount { get; set; }
    
        /// <summary>Cost. Amount_ Multiplier. Integer
        /// urn:x-oca:ocpp:uid:1:569245
        /// Values: -3..3, The amountMultiplier defines the exponent to base 10 (dec). The final value is determined by: amount * 10 ^ amountMultiplier
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("amountMultiplier", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int AmountMultiplier { get; set; }
    
    
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
    
    /// <summary>Relative_ Timer_ Interval
    /// urn:x-oca:ocpp:uid:2:233270
    /// </summary>
    
    public partial class RelativeTimeIntervalType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Relative_ Timer_ Interval. Start. Elapsed_ Time
        /// urn:x-oca:ocpp:uid:1:569279
        /// Start of the interval, in seconds from NOW.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.Always)]
        public int Start { get; set; }
    
        /// <summary>Relative_ Timer_ Interval. Duration. Elapsed_ Time
        /// urn:x-oca:ocpp:uid:1:569280
        /// Duration of the interval, in seconds.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("duration", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Duration { get; set; }
    
    
    }
    
    /// <summary>Sales_ Tariff_ Entry
    /// urn:x-oca:ocpp:uid:2:233271
    /// </summary>
    
    public partial class SalesTariffEntryType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("relativeTimeInterval", Required = Newtonsoft.Json.Required.Always)]
        public RelativeTimeIntervalType RelativeTimeInterval { get; set; } = new RelativeTimeIntervalType();
    
        /// <summary>Sales_ Tariff_ Entry. E_ Price_ Level. Unsigned_ Integer
        /// urn:x-oca:ocpp:uid:1:569281
        /// Defines the price level of this SalesTariffEntry (referring to NumEPriceLevels). Small values for the EPriceLevel represent a cheaper TariffEntry. Large values for the EPriceLevel represent a more expensive TariffEntry.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("ePriceLevel", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int EPriceLevel { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("consumptionCost", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ConsumptionCostType> ConsumptionCost { get; set; }
    
    
    }
    
    /// <summary>Sales_ Tariff
    /// urn:x-oca:ocpp:uid:2:233272
    /// NOTE: This dataType is based on dataTypes from &amp;lt;&amp;lt;ref-ISOIEC15118-2,ISO 15118-2&amp;gt;&amp;gt;.
    /// </summary>
    
    public partial class SalesTariffType 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Identified_ Object. MRID. Numeric_ Identifier
        /// urn:x-enexis:ecdm:uid:1:569198
        /// SalesTariff identifier used to identify one sales tariff. An SAID remains a unique identifier for one schedule throughout a charging session.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public int Id { get; set; }
    
        /// <summary>Sales_ Tariff. Sales. Tariff_ Description
        /// urn:x-oca:ocpp:uid:1:569283
        /// A human readable title/short description of the sales tariff e.g. for HMI display purposes.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("salesTariffDescription", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SalesTariffDescription { get; set; }
    
        /// <summary>Sales_ Tariff. Num_ E_ Price_ Levels. Counter
        /// urn:x-oca:ocpp:uid:1:569284
        /// Defines the overall number of distinct price levels used across all provided SalesTariff elements.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("numEPriceLevels", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int NumEPriceLevels { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("salesTariffEntry", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<SalesTariffEntryType> SalesTariffEntry { get; set; } = new System.Collections.ObjectModel.Collection<SalesTariffEntryType>();
    
    
    }
    
    
    public partial class Anonymous 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Number of the EVSE on which to start the transaction. EvseId SHALL be &amp;gt; 0
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("evseId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int EvseId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("groupIdToken", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IdTokenType GroupIdToken { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("idToken", Required = Newtonsoft.Json.Required.Always)]
        public IdTokenType IdToken { get; set; } = new IdTokenType();
    
        /// <summary>Id given by the server to this start request. The Charging Station might return this in the &amp;lt;&amp;lt;transactioneventrequest, TransactionEventRequest&amp;gt;&amp;gt;, letting the server know which transaction was started for this request. Use to start a transaction.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("remoteStartId", Required = Newtonsoft.Json.Required.Always)]
        public int RemoteStartId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("chargingProfile", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ChargingProfileType ChargingProfile { get; set; }
    
    
    }
}