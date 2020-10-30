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
    
    /// <summary>If provided the Charging Station shall return Display Messages with the given priority only.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum MessagePriorityEnumType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"AlwaysFront")]
        AlwaysFront = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"InFront")]
        InFront = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"NormalCycle")]
        NormalCycle = 2,
    
    }
    
    /// <summary>If provided the Charging Station shall return Display Messages with the given state only. 
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum MessageStateEnumType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Charging")]
        Charging = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Faulted")]
        Faulted = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Idle")]
        Idle = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Unavailable")]
        Unavailable = 3,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.2.2.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class Anonymous 
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>If provided the Charging Station shall return Display Messages of the given ids. This field SHALL NOT contain more ids than set in &amp;lt;&amp;lt;configkey-number-of-display-messages,NumberOfDisplayMessages.maxLimit&amp;gt;&amp;gt;
        /// 
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<int> Id { get; set; }
    
        /// <summary>The Id of this request.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("requestId", Required = Newtonsoft.Json.Required.Always)]
        public int RequestId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("priority", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MessagePriorityEnumType Priority { get; set; }
    
        [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MessageStateEnumType State { get; set; }
    
    
    }
}