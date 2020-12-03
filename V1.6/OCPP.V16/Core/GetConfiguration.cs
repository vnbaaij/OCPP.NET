using System.Collections.Generic;
namespace OCPP.V16.Core
{
    public record GetConfigurationRequest(ICollection<string> Key = null) : RequestBase<GetConfigurationRequest>; 
    
}