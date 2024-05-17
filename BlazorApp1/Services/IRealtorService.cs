using HomeHavenBlazorProject.Models;

namespace HomeHavenBlazorProject.Services
{
    public interface IRealtorService
    {
        Task<IEnumerable<Realtor>> GetAllAsync();
        Task<Realtor> GetAsync(string id);
        Task<Realtor> CreateAsync();
        Task UpdateAsync(Realtor realtor, string id);
        Task DeleteAsync(int id);
    }
}
