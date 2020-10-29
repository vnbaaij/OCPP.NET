namespace OCPP
{
    public partial class ClearVariableMonitoringRequest
    {


        /// <summary>List of the monitors to be cleared, identified by there Id.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public System.Collections.Generic.ICollection<int> Id { get; set; } = new System.Collections.ObjectModel.Collection<int>();


    }
}