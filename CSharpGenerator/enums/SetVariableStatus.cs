namespace OCPP
{
    /// <summary>Result status of setting the variable.
    /// </summary>

    public enum SetVariableStatus
    {
        
        Accepted = 0,
    
        
        Rejected = 1,
    
        
        UnknownComponent = 2,
    
        
        UnknownVariable = 3,
    
        
        NotSupportedAttributeType = 4,
    
        
        RebootRequired = 5,
    
    }
}