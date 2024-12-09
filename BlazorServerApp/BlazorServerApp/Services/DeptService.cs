using BlazorServerApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;

namespace BlazorServerApp.Services
{
    public class DeptService : IDeptService
    {
        private readonly HttpClient httpClient;
        public DeptService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<IDept>> GetDepts()
        {
            return await httpClient.GetFromJsonAsync<List<IDept>>("dept/listdept");
        }
        public async Task<IDept> DisplayDept(int id)
        {
            return await httpClient.GetFromJsonAsync<IDept>("dept/listdept/" + id);
        }
         

    }
}
