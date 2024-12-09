using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_CRUD_InMem_App.Data
{
    public class EmployeeService : IEmployeeService
    {
        private List<Employee> employees = new List<Employee>()
        {
            new Employee{Id=Guid.NewGuid(),Name="emp1"},
            new Employee{Id=Guid.NewGuid(),Name="emp2"}

        };

        public Employee GetEmployee(Guid id)
        {
            return employees.SingleOrDefault(e => e.Id == id);
        }

        public List<Employee> GetEmployees()
        {
            return this.employees;
        }

        public void UpdateEmployee(Employee emp)
        {
            var getoldemployee = GetEmployee(emp.Id);
            getoldemployee.Name = emp.Name;
        }

        public void AddEmployee(Employee employee)
        {
            var Id = Guid.NewGuid();
            employee.Id = Id;
            employees.Add(employee);
        }

        public void DeleteEmployee(Guid id)
        {
           var emp = GetEmployee(id);
            employees.Remove(emp);

        }
    }
}
