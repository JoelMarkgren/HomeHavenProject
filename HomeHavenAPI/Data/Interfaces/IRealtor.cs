using HomeHavenAPI.Models;

namespace HomeHavenAPI.Data.Interfaces
{
    public interface IRealtor
    {
        Task<Realtor> GetAsync(string id);
        Task<IEnumerable<Realtor>> GetAllAsync();
        Task<Realtor> EditAsync(Realtor realtor, string id);
        Task DeleteAsync(string id);
        Task CreateAsync(Realtor realtor);

    }
}
