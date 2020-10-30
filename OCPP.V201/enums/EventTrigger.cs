namespace OCPP.V201
{
    /// <summary>Type of monitor that triggered this event, e.g. exceeding a threshold value.
    /// 
    /// </summary>

    public enum EventTrigger
    {
        
        Alerting = 0,
        Delta = 1,
        Periodic = 2,
    
    }
}