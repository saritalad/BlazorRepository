#pragma checksum "E:\A_Synergetics\Blazor\BlazorPracticeVS22\BlazorRCA\Pages\Three.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dc65038332a065ddfba8e280bcaa76bdad05837"
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
    public partial class Three : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "p-5 bg-warning");
            __builder.OpenElement(2, "h3");
            __builder.AddAttribute(3, "class", "text-white");
            __builder.AddContent(4, 
#nullable restore
#line 2 "E:\A_Synergetics\Blazor\BlazorPracticeVS22\BlazorRCA\Pages\Three.razor"
                            TransferredValue

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "E:\A_Synergetics\Blazor\BlazorPracticeVS22\BlazorRCA\Pages\Three.razor"
       
    [CascadingParameter]
    public string TransferredValue { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
