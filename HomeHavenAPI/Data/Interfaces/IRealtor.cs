using HomeHavenAPI.Models;

namespace HomeHavenAPI.Data.Interfaces
{
    public interface IRealtor
    {
        Task<Realtor> GetAsync(int id);
        Task<IEnumerable<Realtor>> GetAllAsync();
        Task<Realtor> EditAsync(Realtor realtor);
        Task DeleteAsync(int id);
        Task CreateAsync(Realtor realtor);

    }
}
