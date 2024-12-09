using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Services
{
    interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();
    }
}
