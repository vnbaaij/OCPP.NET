
using OCPP.V16.Core;

namespace OCPP.V16.SmartCharging
{
    public record ClearChargingProfileRequest(int? Id = null, int? ConnectorId = null, ChargingProfilePurposeType? ChargingProfilePurpose = null, int? StackLevel = null) : RequestBase<ClearChargingProfileRequest>;
    public record GetCompositeScheduleRequest(int ConnectorId, int Duration, ChargingRateUnitType? ChargingRateUnit = null) : RequestBase<GetCompositeScheduleRequest>;
    public record SetChargingProfileRequest(int ConnectorId, ChargingProfile CsChargingProfiles) : RequestBase<SetChargingProfileRequest>;
}
