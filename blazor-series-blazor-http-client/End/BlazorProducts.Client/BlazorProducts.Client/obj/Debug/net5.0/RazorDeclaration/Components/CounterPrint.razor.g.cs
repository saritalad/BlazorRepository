// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorProducts.Client.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\A_Synergetics\Blazor\blazor-series-blazor-http-client\End\BlazorProducts.Client\BlazorProducts.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\A_Synergetics\Blazor\blazor-series-blazor-http-client\End\BlazorProducts.Client\BlazorProducts.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\A_Synergetics\Blazor\blazor-series-blazor-http-client\End\BlazorProducts.Client\BlazorProducts.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\A_Synergetics\Blazor\blazor-series-blazor-http-client\End\BlazorProducts.Client\BlazorProducts.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\A_Synergetics\Blazor\blazor-series-blazor-http-client\End\BlazorProducts.Client\BlazorProducts.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\A_Synergetics\Blazor\blazor-series-blazor-http-client\End\BlazorProducts.Client\BlazorProducts.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\A_Synergetics\Blazor\blazor-series-blazor-http-client\End\BlazorProducts.Client\BlazorProducts.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\A_Synergetics\Blazor\blazor-series-blazor-http-client\End\BlazorProducts.Client\BlazorProducts.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\A_Synergetics\Blazor\blazor-series-blazor-http-client\End\BlazorProducts.Client\BlazorProducts.Client\_Imports.razor"
using BlazorProducts.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\A_Synergetics\Blazor\blazor-series-blazor-http-client\End\BlazorProducts.Client\BlazorProducts.Client\_Imports.razor"
using BlazorProducts.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\A_Synergetics\Blazor\blazor-series-blazor-http-client\End\BlazorProducts.Client\BlazorProducts.Client\_Imports.razor"
using BlazorProducts.Client.Components;

#line default
#line hidden
#nullable disable
    public partial class CounterPrint : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "E:\A_Synergetics\Blazor\blazor-series-blazor-http-client\End\BlazorProducts.Client\BlazorProducts.Client\Components\CounterPrint.razor"
       
    [Parameter]
    public string Title { get; set; }
    [Parameter]
    public int CurrentCount { get; set; }

    protected override void OnInitialized()
    {
        Console.WriteLine($"OnInitialized => Title: {Title}, CurrentCount: {CurrentCount}");
    }

    protected override void OnParametersSet()
    {
        Console.WriteLine($"OnParameterSet => Title: {Title}, CurrentCount: {CurrentCount}");
    }

    protected override void OnAfterRender(bool firstRender)
    {
        if(firstRender)
        {
            Console.WriteLine("This is the first render of the component");
        }
    }

    protected override bool ShouldRender()
    {
        return false;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
