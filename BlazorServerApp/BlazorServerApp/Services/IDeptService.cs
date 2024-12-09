using BlazorServerApp.Models;

namespace BlazorServerApp.Services
{
    public interface IDeptService
    {
        Task<List<IDept>> GetDepts();
        Task<IDept> DisplayDept(int id);
        //Task<IDept> AddDept(IDept dept);
    }
}
