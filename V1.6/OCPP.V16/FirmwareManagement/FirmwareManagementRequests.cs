using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPP.V16.FirmwareManagement
{
    public record DiagnosticsStatusNotificationRequest(DiagnosticsStatus Status) : RequestBase<DiagnosticsStatusNotificationRequest>;
    public record FirmwareStatusNotificationRequest(FirmwareStatus Status) : RequestBase<FirmwareStatusNotificationRequest>;
    public record GetDiagnosticsRequest(Uri Location, int? Retries = null, int? RetryInterval = null, DateTime? StartTime = null, DateTime? StopTime = null) : RequestBase<GetDiagnosticsRequest>;
    public record UpdateFirmwareRequest(Uri Location, DateTime RetrieveDate, int? Retries = null, int? RetryInterval = null) : RequestBase<UpdateFirmwareRequest>;
}
