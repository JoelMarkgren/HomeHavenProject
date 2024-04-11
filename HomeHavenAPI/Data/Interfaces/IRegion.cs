using HomeHavenAPI.Models;

namespace HomeHavenAPI.Data.Interfaces
{
    public interface IRegion
    {
        Task<Region> Get(int id);
        Task<IEnumerable<Region>> GetAll();
        
    }
}
