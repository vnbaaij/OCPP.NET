using OCPP.V16;

using OCPP.V16;
namespace OCPP.V16.Core
{
    public partial class BootNotificationRequest : RequestBase<BootNotificationRequest>
    {
        //[Newtonsoft.Json.JsonProperty("chargePointVendor", Required = Newtonsoft.Json.Required.Always)]
        public string ChargePointVendor { get; set; }

        //[Newtonsoft.Json.JsonProperty("chargePointModel", Required = Newtonsoft.Json.Required.Always)]
        public string ChargePointModel { get; set; }

        //[Newtonsoft.Json.JsonProperty("chargePointSerialNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChargePointSerialNumber { get; set; }

        //[Newtonsoft.Json.JsonProperty("chargeBoxSerialNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChargeBoxSerialNumber { get; set; }

        //[Newtonsoft.Json.JsonProperty("firmwareVersion", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirmwareVersion { get; set; }

        //[Newtonsoft.Json.JsonProperty("iccid", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Iccid { get; set; }

        //[Newtonsoft.Json.JsonProperty("imsi", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Imsi { get; set; }

        //[Newtonsoft.Json.JsonProperty("meterType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MeterType { get; set; }

        //[Newtonsoft.Json.JsonProperty("meterSerialNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MeterSerialNumber { get; set; }

        public BootNotificationRequest()
        {

        }
        public BootNotificationRequest(string chargePointVendor, string chargePointModel,string chargePointSerialNumber = null, string chargeBoxSerialNumber = null, string firmwareVersion = null, string iccid = null, string imsi = null, string meterType = null, string meterSerialNumber = null)
        {
            ChargePointVendor = chargePointVendor;
            ChargePointModel = chargePointModel;
            ChargePointSerialNumber = chargePointSerialNumber;
            ChargeBoxSerialNumber = chargeBoxSerialNumber;
            FirmwareVersion = firmwareVersion;
            Iccid = iccid;
            Imsi = imsi;
            MeterType = meterType;
            MeterSerialNumber = meterSerialNumber;

        }
    }
}