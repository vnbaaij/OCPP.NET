using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorChargePointTest
{
    public class NotifierService
    {
        // Can be called from anywhere
        public async Task Update()
        {
            if (Notify != null)
            {
                await Notify.Invoke();
            }
        }

        public event Func<Task> Notify;
    }
}
