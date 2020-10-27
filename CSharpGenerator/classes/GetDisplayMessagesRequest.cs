





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
    
    /// <summary>If provided the Charging Station shall return Display Messages with the given priority only.
    /// </summary>
    
    public enum MessagePriorityEnumType
    {
        
        AlwaysFront = 0,
    
        
        InFront = 1,
    
        
        NormalCycle = 2,
    
    }
    
    /// <summary>If provided the Charging Station shall return Display Messages with the given state only. 
    /// </summary>
    
    public enum MessageStateEnumType
    {
        
        Charging = 0,
    
        
        Faulted = 1,
    
        
        Idle = 2,
    
        
        Unavailable = 3,
    
    }
    
    
    public partial class Anonymous 
    {
        //[Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }
    
        /// <summary>If provided the Charging Station shall return Display Messages of the given ids. This field SHALL NOT contain more ids than set in &amp;lt;&amp;lt;configkey-number-of-display-messages,NumberOfDisplayMessages.maxLimit&amp;gt;&amp;gt;
        /// 
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<int> Id { get; set; }
    
        /// <summary>The Id of this request.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("requestId", Required = Newtonsoft.Json.Required.Always)]
        public int RequestId { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("priority", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MessagePriorityEnumType Priority { get; set; }
    
        //[Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MessageStateEnumType State { get; set; }
    
    
    }
}