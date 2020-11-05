﻿using OCPP.V16;
namespace OCPP.V16.Core
{
    public enum StatusNotificationRequestStatus
    {
        Available,
        Preparing,
        Charging,
        SuspendedEVSE,
        SuspendedEV,
        Finishing,
        Reserved,
        Unavailable,
        Faulted,
    }
}