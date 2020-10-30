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
    
    /// <summary>This field specifies the connector type.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum ConnectorEnumType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"cCCS1")]
        CCCS1 = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"cCCS2")]
        CCCS2 = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"cG105")]
        CG105 = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"cTesla")]
        CTesla = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"cType1")]
        CType1 = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"cType2")]
        CType2 = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = @"s309-1P-16A")]
        S3091P16A = 6,
    
        [System.Runtime.Serialization.EnumMember(Value = @"s309-1P-32A")]
        S3091P32A = 7,
    
        [System.Runtime.Serialization.EnumMember(Value = @"s309-3P-16A")]
        S3093P16A = 8,
    
        [System.Runtime.Serialization.EnumMember(Value = @"s309-3P-32A")]
        S3093P32A = 9,
    
        [System.Runtime.Serialization.EnumMember(Value = @"sBS1361")]
        SBS1361 = 10,
    
        [System.Runtime.Serialization.EnumMember(Value = @"sCEE-7-7")]
        SCEE77 = 11,
    
        [System.Runtime.Serialization.EnumMember(Value = @"sType2")]
        SType2 = 12,
    
        [System.Runtime.Serialization.EnumMember(Value = @"sType3")]
        SType3 = 13,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Other1PhMax16A")]
        Other1PhMax16A = 14,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Other1PhOver16A")]
        Other1PhOver16A = 15,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Other3Ph")]
        Other3Ph = 16,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Pan")]
        Pan = 17,
    
        [System.Runtime.Serialization.EnumMember(Value = @"wInductive")]
        WInductive = 18,
    
        [System.Runtime.Serialization.EnumMember(Value = @"wResonant")]
        WResonant = 19,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Undetermined")]
        Undetermined = 20,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Unknown")]
        Unknown = 21,
    
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
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Anonymous 
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>Id of reservation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public int Id { get; set; }
    
        /// <summary>Date and time at which the reservation expires.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expiryDateTime", Required = Newtonsoft.Json.Required.Always)]
        public System.DateTimeOffset ExpiryDateTime { get; set; }
    
        [Newtonsoft.Json.JsonProperty("connectorType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ConnectorEnumType ConnectorType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("idToken", Required = Newtonsoft.Json.Required.Always)]
        public IdTokenType IdToken { get; set; } = new IdTokenType();
    
        /// <summary>This contains ID of the evse to be reserved.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("evseId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int EvseId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("groupIdToken", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IdTokenType GroupIdToken { get; set; }
    
    
    }
}