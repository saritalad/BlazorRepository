#pragma checksum "E:\A_Synergetics\Blazor\BlazorPracticeVS22\BlazorRCA\Pages\ExampleE.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "815dc1ee05800467e935044a9ce645935b676303"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/ExampleE")]
    public partial class ExampleE : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    #components-reconnect-modal {
        position: fixed;
        top: 0;
        right: 0;
        bottom: 0;
        left: 0;
        z-index: 100;
        opacity: 0.8;
    }

    .components-reconnect-hide, .components-reconnect-show > .failed, .components-reconnect-show > .rejected, .components-reconnect-failed> .reconnect, .components-reconnect-failed > .rejected, .components-reconnect-rejected > .reconnect, .components-reconnect-rejected > .failed {
        display: none;
    }

    .components-reconnect-show, .components-reconnect-show > .reconnect, .components-reconnect-failed > .failed, .components-reconnect-rejected> .rejected {
        display: block;
    }
</style>

");
            __builder.AddMarkupContent(1, @"<div id=""components-reconnect-modal"" class=""h3 bg-danger text-white text-center my-1 p-1 components-reconnect-hide"">
    Blazor Connection Lost
    <div class=""reconnect"">
        Trying to reconnect...
    </div>
    <div class=""failed"">
        Reconnection Failed.
        <button class=""btn btn-light"" onclick=""window.Blazor.reconnect()"">
            Reconnect
        </button></div>
    <div class=""rejected"">
        Reconnection Rejected.
        <button class=""btn btn-light"" onclick=""location.reload()"">
            Reload
        </button></div></div>

");
            __builder.AddMarkupContent(2, "<div id=\"blazor-error-ui\" class=\"text-center bg-warning text-white p-1\" style=\"display:none\">\r\n    An error has occurred. Kindly Reload.\r\n    <button class=\"btn btn-sm btn-primary\" onclick=\"location.reload()\">\r\n        Reload\r\n    </button></div>\r\n\r\n");
            __builder.AddMarkupContent(3, "<h1 class=\"bg-info text-white\">Blazor Errors</h1>\r\n\r\n");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "btn btn-danger");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "E:\A_Synergetics\Blazor\BlazorPracticeVS22\BlazorRCA\Pages\ExampleE.razor"
                                           () => throw new Exception()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n    Error\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
