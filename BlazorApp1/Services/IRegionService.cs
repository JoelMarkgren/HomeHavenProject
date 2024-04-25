using HomeHavenBlazorProject.Models;

namespace HomeHavenBlazorProject.Services
{
    public interface IRegionService
    {
        Task<IEnumerable<Region>> GetAllAsync();
        Task<Region> GetAsync(int id);
    }
}
