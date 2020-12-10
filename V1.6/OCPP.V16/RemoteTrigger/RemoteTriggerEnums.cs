using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPP.V16.RemoteTrigger
{
    public enum MessageTrigger
    {
        BootNotification,
        DiagnosticsStatusNotification,
        FirmwareStatusNotification,
        Heartbeat,
        MeterValues,
        StatusNotification,
    }

    public enum TriggerMessageStatus
    {
        Accepted,
        Rejected,
        NotImplemented,
    }
}
