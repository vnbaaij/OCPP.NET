namespace OCPP.V201
{
    /// <summary>Sampled_ Value. Phase. Phase_ Code
    /// urn:x-oca:ocpp:uid:1:569264
    /// Indicates how the measured value is to be interpreted. For instance between L1 and neutral (L1-N) Please note that not all values of phase are applicable to all Measurands. When phase is absent, the measured value is interpreted as an overall value.
    /// </summary>

    public enum Phase
    {

        L1 = 0,
        L2 = 1,
        L3 = 2,
        N = 3,
        L1N = 4,
        L2N = 5,
        L3N = 6,
        L1L2 = 7,
        L2L3 = 8,
        L3L1 = 9,

    }
}