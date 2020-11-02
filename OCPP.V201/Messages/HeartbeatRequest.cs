using OCPP.Core;

namespace OCPP.V201
{
    public partial class HeartbeatRequest : RequestBase<HeartbeatRequest>
    {
        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }
    
    }
}