using HomeHavenAPI.Models;

namespace HomeHavenAPI.Data.Interfaces
{
    public interface IBroker
    {
        Task<Broker> GetAsync(int id);
        Task<IEnumerable<Broker>> GetAllAsync();
        Task<Broker> EditAsync(Broker broker);
        Task DeleteAsync(int id);
        Task CreateAsync(Broker broker);

    }
}
