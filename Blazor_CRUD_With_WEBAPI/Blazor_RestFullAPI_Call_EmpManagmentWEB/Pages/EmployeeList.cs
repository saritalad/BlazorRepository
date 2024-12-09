using Blazor_RestFullAPI_Call_EmpManagmentWEB.Services;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_RestFullAPI_Call_EmpManagmentWEB.Pages
{
    public partial class EmployeeList:ComponentBase
    {
        // can not inject in constructor  like service here in razor we hv to use inject attribute
        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetEmployees()).ToList();
        }
    }
}
