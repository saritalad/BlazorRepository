using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_CRUD_InMem_App.Data
{
   public interface IEmployeeService
    {
        public List<Employee> GetEmployees();
        public Employee GetEmployee(Guid id);
        public void UpdateEmployee(Employee emp);
        public void AddEmployee(Employee emp);
        public void DeleteEmployee(Guid id);
    }
}
