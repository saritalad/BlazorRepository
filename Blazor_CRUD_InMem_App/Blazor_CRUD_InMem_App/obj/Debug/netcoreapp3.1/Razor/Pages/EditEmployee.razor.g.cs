#pragma checksum "E:\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\Pages\EditEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "026b5b63ad5f74c87e870dfd434d5ae242f0118e"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/emp/{Id}")]
    public partial class EditEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit Employee</h3>\r\n\r\n");
            __builder.OpenElement(1, "h2");
            __builder.AddContent(2, "Id :  ");
#nullable restore
#line 6 "E:\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\Pages\EditEmployee.razor"
__builder.AddContent(3, emp.Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "h2");
            __builder.AddContent(6, "Name: ");
#nullable restore
#line 7 "E:\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\Pages\EditEmployee.razor"
__builder.AddContent(7, emp.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(9);
            __builder.AddAttribute(10, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "E:\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\Pages\EditEmployee.razor"
                 emp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "OnSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "E:\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\Pages\EditEmployee.razor"
                                 SubmitForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(13, "\r\n    ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group");
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.AddMarkupContent(17, "<label>Id</label>\r\n        ");
                __builder2.OpenElement(18, "input");
                __builder2.AddAttribute(19, "id", "id");
                __builder2.AddAttribute(20, "class", "form-control");
                __builder2.AddAttribute(21, "name", "id");
                __builder2.AddAttribute(22, "value", 
#nullable restore
#line 11 "E:\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\Pages\EditEmployee.razor"
                                                              emp.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(23, "readonly", true);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n    ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group");
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.AddMarkupContent(29, "<label>Name</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "id", "Name");
                __builder2.AddAttribute(32, "class", "form-control");
                __builder2.AddAttribute(33, "name", "name");
                __builder2.AddAttribute(34, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "E:\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\Pages\EditEmployee.razor"
                                                                           emp.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => emp.Name = __value, emp.Name))));
                __builder2.AddAttribute(36, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => emp.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n   \r\n        ");
                __builder2.AddMarkupContent(39, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n    \r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "E:\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\Pages\EditEmployee.razor"
       
        [Parameter]
        public string Id { get; set; }
    public Blazor_CRUD_InMem_App.Data.Employee emp { get; set; }

    protected override void OnInitialized()
    {
        if (!string.IsNullOrEmpty(Id) && Id == "0")
        {
            emp = new Data.Employee();
        }
        else
        {
            emp = empservice.GetEmployee(Guid.Parse(Id));
        }
    }
    private void SubmitForm()
    {
        if (emp.Id == Guid.Empty)
        {
            empservice.AddEmployee(emp);
        }
        else
        { empservice.UpdateEmployee(emp); }
        navigation.NavigateTo("Employees");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazor_CRUD_InMem_App.Data.IEmployeeService empservice { get; set; }
    }
}
#pragma warning restore 1591