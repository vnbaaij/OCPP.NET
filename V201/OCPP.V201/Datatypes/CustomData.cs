using System;
using System.Collections.Generic;
using System.Text;

namespace OCPP.V201
{
    public partial class CustomData
    {
        //[Newtonsoft.Json.JsonProperty("vendorId", Required = Newtonsoft.Json.Required.Always)]
        public string VendorId { get; set; }

        private IDictionary<string, object> _additionalProperties = new Dictionary<string, object>();

        //[Newtonsoft.Json.JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }


    }
}
