namespace OCPP.V16.Core
{
    public record ChangeAvailabilityRequest(int ConnectorId, AvailabilityType Type) : RequestBase<ChangeAvailabilityRequest>;
}