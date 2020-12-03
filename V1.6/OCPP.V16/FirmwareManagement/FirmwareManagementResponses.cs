namespace OCPP.V16.FirmwareManagement
{
    public record GetDiagnosticsResponse(GetDiagnosticsRequest Request, string FileName) : ResponseBase<GetDiagnosticsRequest, GetDiagnosticsResponse>(Request);
}
