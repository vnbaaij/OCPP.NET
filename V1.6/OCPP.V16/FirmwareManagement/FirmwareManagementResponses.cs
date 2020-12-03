using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPP.V16.FirmwareManagement
{
    public record GetDiagnosticsResponse(GetDiagnosticsRequest Request, string FileName) : ResponseBase<GetDiagnosticsRequest, GetDiagnosticsResponse>(Request);
}
