#pragma checksum "E:\A_Synergetics\Blazor\BlazorApp1\BlazorApp1\Pages\MyComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06953038501869bf046102e6b40848256de3e36d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\A_Synergetics\Blazor\BlazorApp1\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\A_Synergetics\Blazor\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\A_Synergetics\Blazor\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\A_Synergetics\Blazor\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\A_Synergetics\Blazor\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\A_Synergetics\Blazor\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\A_Synergetics\Blazor\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\A_Synergetics\Blazor\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\A_Synergetics\Blazor\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\A_Synergetics\Blazor\BlazorApp1\BlazorApp1\Pages\MyComponent.razor"
using BlazorApp1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\A_Synergetics\Blazor\BlazorApp1\BlazorApp1\Pages\MyComponent.razor"
using BlazorApp1.Pages.ContactComponents;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/MyComponent")]
    public partial class MyComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3> My Contacts List Displayed here</h3>\r\n");
            __builder.OpenElement(1, "h2");
#nullable restore
#line 6 "E:\A_Synergetics\Blazor\BlazorApp1\BlazorApp1\Pages\MyComponent.razor"
__builder.AddContent(2, config["ClientName"]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 7 "E:\A_Synergetics\Blazor\BlazorApp1\BlazorApp1\Pages\MyComponent.razor"
 foreach (var c in contacts)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenComponent<BlazorApp1.Pages.ContactComponents.ContactComponent1>(5);
            __builder.AddAttribute(6, "Name", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "E:\A_Synergetics\Blazor\BlazorApp1\BlazorApp1\Pages\MyComponent.razor"
                              c.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "Mail", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "E:\A_Synergetics\Blazor\BlazorApp1\BlazorApp1\Pages\MyComponent.razor"
                                             c.Mail

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 12 "E:\A_Synergetics\Blazor\BlazorApp1\BlazorApp1\Pages\MyComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "E:\A_Synergetics\Blazor\BlazorApp1\BlazorApp1\Pages\MyComponent.razor"
       

    private List<Contact> contacts;
   
    protected override void OnInitialized()

    {
        base.OnInitialized();
        contacts = new List<Contact>()
    {
            new Contact {Name="Bill",Mail="Bill@gmail.com"},
            new Contact {Name="Mill",Mail="Mill@gmail.com"},
            new Contact {Name="Gill",Mail="Gill@gmail.com"}
        };
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
    }
}
#pragma warning restore 1591
