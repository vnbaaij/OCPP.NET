using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPP.V16.ListManagement
{
    public enum UpdateStatus
    {
        Accepted,
        Failed,
        NotSupported,
        VersionMismatch,
    }

    public enum UpdateType
    {
        Differential,
        Full,
    }
}
