using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2_Partial_Base.Pages
{
    public class CounterBase:ComponentBase
    {
       protected int currentCount = 0;

        protected void IncrementCount()
        {
            currentCount++;
        }
    }
}
