#pragma checksum "E:\A_Synergetics\Blazor\BlazorPracticeVS22\BlazorRCA\Pages\GT.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31df11099e6b7862d88f3523def5d009bcd519cb"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/GT")]
    public partial class GT : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<BlazorRCA.Pages.TableTemplate<Person>>(0);
            __builder.AddAttribute(1, "RowData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Person>>(
#nullable restore
#line 3 "E:\A_Synergetics\Blazor\BlazorPracticeVS22\BlazorRCA\Pages\GT.razor"
                                         persons

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "<tr><th>Name</th><th>City</th></tr>");
            }
            ));
            __builder.AddAttribute(4, "RowTemplate", (Microsoft.AspNetCore.Components.RenderFragment<Person>)((p) => (__builder2) => {
                __builder2.OpenElement(5, "td");
                __builder2.AddContent(6, 
#nullable restore
#line 8 "E:\A_Synergetics\Blazor\BlazorPracticeVS22\BlazorRCA\Pages\GT.razor"
             p.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenElement(8, "td");
                __builder2.AddContent(9, 
#nullable restore
#line 9 "E:\A_Synergetics\Blazor\BlazorPracticeVS22\BlazorRCA\Pages\GT.razor"
             p.City

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "E:\A_Synergetics\Blazor\BlazorPracticeVS22\BlazorRCA\Pages\GT.razor"
       
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
