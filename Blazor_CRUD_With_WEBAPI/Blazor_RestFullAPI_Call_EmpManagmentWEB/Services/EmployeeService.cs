using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using Newtonsoft.Json;

namespace Blazor_RestFullAPI_Call_EmpManagmentWEB.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            
        }
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            try
            {
              // string baseurl = "http://localhost:5000/";

                 var response = await httpClient.GetAsync("api/employees");
               
                if(response.IsSuccessStatusCode)
                {
                    var employees = await response.Content.ReadAsStringAsync();


                    return JsonConvert.DeserializeObject<IEnumerable<Employee>>(employees);
                }
                
              return await this.httpClient.GetFromJsonAsync<IEnumerable<Employee>>("api/employees");
              
            }
            catch (Exception )
            {
                return Enumerable.Empty<Employee>();
            }
            }
    }
}
