using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPP.V16.FirmwareManagement
{
    public enum DiagnosticsStatus
    {
        Idle,
        Uploaded,
        UploadFailed,
        Uploading,
    }

    public enum FirmwareStatus
    {
        Downloaded,
        DownloadFailed,
        Downloading,
        Idle,
        InstallationFailed,
        Installing,
        Installed,
    }
}
