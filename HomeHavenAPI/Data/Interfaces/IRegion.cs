using HomeHavenAPI.Models;

namespace HomeHavenAPI.Data.Interfaces
{
    public interface IRegion
    {
        Task<Region> GetAsync(int id);
        Task<IEnumerable<Region>> GetAllAsync();
        
    }
}
