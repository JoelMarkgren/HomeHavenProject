using HomeHavenAPI.Models;

namespace HomeHavenAPI.Data.Interfaces
{
    public interface IBroker
    {
        Task<Broker> Get(int id);
        Task<IEnumerable<Broker>> GetAll();
        Task<Broker> Edit(int id);
        void Delete(int id);
        Task<Broker> Create();

    }
}
