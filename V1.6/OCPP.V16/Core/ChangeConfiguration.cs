namespace OCPP.V16.Core
{
    public record ChangeConfigurationRequest(string Key, string Value) : RequestBase<ChangeConfigurationRequest>; 

}