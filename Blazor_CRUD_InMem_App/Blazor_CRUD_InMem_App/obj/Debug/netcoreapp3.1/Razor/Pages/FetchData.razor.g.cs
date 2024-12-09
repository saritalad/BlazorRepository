#pragma checksum "E:\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7b0e9421c6a433174d94812c24f173c47e5464c"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_CRUD_InMem_App.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\_Imports.razor"
using Blazor_CRUD_InMem_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\_Imports.razor"
using Blazor_CRUD_InMem_App.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\Pages\FetchData.razor"
using Blazor_CRUD_InMem_App.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>\r\n\r\n");
#nullable restore
#line 10 "E:\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 13 "E:\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 26 "E:\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
#nullable restore
#line 29 "E:\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\Pages\FetchData.razor"
__builder.AddContent(15, forecast.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
#nullable restore
#line 30 "E:\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\Pages\FetchData.razor"
__builder.AddContent(18, forecast.TemperatureC);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
#nullable restore
#line 31 "E:\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\Pages\FetchData.razor"
__builder.AddContent(21, forecast.TemperatureF);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
#nullable restore
#line 32 "E:\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\Pages\FetchData.razor"
__builder.AddContent(24, forecast.Summary);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 34 "E:\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 37 "E:\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "E:\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591