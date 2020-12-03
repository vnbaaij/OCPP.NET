using System;

using OCPP.V16.Core;

namespace OCPP.V16.SmartCharging
{
    public record ClearChargingProfileResponse(ClearChargingProfileRequest Request, ClearChargingProfileStatus Status) : ResponseBase<ClearChargingProfileRequest, ClearChargingProfileResponse>(Request);
    public record GetCompositeScheduleResponse(GetCompositeScheduleRequest Request, GetCompositeScheduleStatus Status, int ConnectorId, DateTime ScheduleStart, ChargingSchedule ChargingSchedule) : ResponseBase<GetCompositeScheduleRequest, GetCompositeScheduleResponse>(Request);
    public record SetChargingProfileResponse(SetChargingProfileRequest Request, ChargingProfileStatus Status) : ResponseBase<SetChargingProfileRequest, SetChargingProfileResponse>(Request);

}
