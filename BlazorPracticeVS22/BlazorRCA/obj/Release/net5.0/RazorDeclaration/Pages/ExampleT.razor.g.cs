// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorRCA.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\A_Synergetics\Blazor\BlazorPracticeVS22\BlazorRCA\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\A_Synergetics\Blazor\BlazorPracticeVS22\BlazorRCA\_Imports.razor"
using BlazorRCA.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\A_Synergetics\Blazor\BlazorPracticeVS22\BlazorRCA\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ExampleT")]
    public partial class ExampleT : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "E:\A_Synergetics\Blazor\BlazorPracticeVS22\BlazorRCA\Pages\ExampleT.razor"
       
    private List<Person> persons = new List<Person>{
        new Person { Name = "Jack", City = "New York" },
        new Person { Name = "Sarah", City = "Boston" },
        new Person { Name = "Chan", City = "Hong Kong" }
    };

    private class Person
    {
        public string Name { get; set; }
        public string City { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
