namespace OCPP.V16.Core
{
    public record BootNotificationRequest(
        string ChargePointVendor,
        string ChargePointModel,
        string ChargePointSerialNumber = null,
        string ChargeBoxSerialNumber = null,
        string FirmwareVersion = null,
        string Iccid = null ,
        string Imsi = null,
        string MeterType = null,
        string MeterSerialNumber = null) : RequestBase<BootNotificationRequest>;
}