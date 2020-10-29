namespace OCPP
{
    /// <summary>The type of this monitor, e.g. a threshold, delta or periodic monitor. 
    /// </summary>

    public enum Monitor
    {
        
        UpperThreshold = 0,
    
        
        LowerThreshold = 1,
    
        
        Delta = 2,
    
        
        Periodic = 3,
    
        
        PeriodicClockAligned = 4,
    
    }
}