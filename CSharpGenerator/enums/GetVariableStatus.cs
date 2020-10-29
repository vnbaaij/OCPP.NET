namespace OCPP
{
    /// <summary>Result status of getting the variable.
    /// 
    /// </summary>

    public enum GetVariableStatus
    {
        
        Accepted = 0,
    
        
        Rejected = 1,
    
        
        UnknownComponent = 2,
    
        
        UnknownVariable = 3,
    
        
        NotSupportedAttributeType = 4,
    
    }
}