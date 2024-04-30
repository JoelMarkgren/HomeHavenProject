using HomeHavenBlazorProject.Models;

namespace HomeHavenBlazorProject.Services
{
    public interface IRealtorService
    {
        Task<IEnumerable<Realtor>> GetAllAsync();
        Task<Realtor> GetAsync(int id);
        Task<Realtor> CreateAsync();
        Task UpdateAsync(int id);
        Task DeleteAsync(int id);
    }
}
