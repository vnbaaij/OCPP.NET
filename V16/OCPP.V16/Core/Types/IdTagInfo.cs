using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

using OCPP.V16;
namespace OCPP.V16.Core
{
    public partial class IdTagInfo
    {
        //[Newtonsoft.Json.JsonProperty("expiryDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [JsonPropertyName("expiryDate")]
        public DateTime ExpiryDate { get; set; }

        //[Newtonsoft.Json.JsonProperty("parentIdTag", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [JsonPropertyName("parentIdTag")]
        public string ParentIdTag { get; set; }

        //[Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        //[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [JsonPropertyName("status")]
        public IdTagInfoStatus Status { get; set; }


    }
}
