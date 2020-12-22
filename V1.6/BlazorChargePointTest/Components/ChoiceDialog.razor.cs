using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using OCPP.V16;

namespace BlazorChargePointTest.Components
{
    public partial class ChoiceDialog
    {
        [Parameter] public bool Show { get; set; }
        [Parameter] public OcppMessage OcppMessage { get; set; }
        [Parameter] public string UserMessage { get; set; }
        [Parameter] public IAction Action { get; set; }
        
        [Parameter] public EventCallback OnReject { get; set; }
        [Parameter] public EventCallback OnAccept { get; set; }
    }
}
