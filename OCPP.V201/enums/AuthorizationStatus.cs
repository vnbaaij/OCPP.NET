﻿namespace OCPP
{
    /// <summary>ID_ Token. Status. Authorization_ Status
    /// urn:x-oca:ocpp:uid:1:569372
    /// Current status of the ID Token.
    /// </summary>

    public enum AuthorizationStatus
    {
        Accepted = 0,
        Blocked = 1,
        ConcurrentTx = 2,
        Expired = 3,
        Invalid = 4,
        NoCredit = 5,
        NotAllowedTypeEVSE = 6,
        NotAtThisLocation = 7,
        NotAtThisTime = 8,
        Unknown = 9,
    }
}