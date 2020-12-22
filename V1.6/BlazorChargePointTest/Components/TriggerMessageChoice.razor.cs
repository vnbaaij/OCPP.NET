using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using OCPP.V16;
using OCPP.V16.RemoteTrigger;

namespace BlazorChargePointTest.Components
{
    public partial class TriggerMessageChoice : ComponentBase
    {
        [CascadingParameter] public OcppMessage Message { get; set; }
        [Parameter] public EventCallback OnReject { get; set; }
        [Parameter] public EventCallback OnAccept { get; set; }

        
    }
}
