// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor_CRUD_InMem_App.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\A_Synergetics\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\A_Synergetics\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\A_Synergetics\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\A_Synergetics\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\A_Synergetics\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\A_Synergetics\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\A_Synergetics\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\A_Synergetics\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\_Imports.razor"
using Blazor_CRUD_InMem_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\A_Synergetics\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\_Imports.razor"
using Blazor_CRUD_InMem_App.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Employees")]
    public partial class Employees : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "E:\A_Synergetics\Blazor\Blazor_CRUD_InMem_App\Blazor_CRUD_InMem_App\Pages\Employees.razor"
           
    private List<Blazor_CRUD_InMem_App.Data.Employee> employees;
    protected override void OnInitialized()
    {
        employees = empservice.GetEmployees();
     
    }
    private void ondelete(Guid id)
    {
        empservice.DeleteEmployee(id);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazor_CRUD_InMem_App.Data.IEmployeeService empservice { get; set; }
    }
}
#pragma warning restore 1591
