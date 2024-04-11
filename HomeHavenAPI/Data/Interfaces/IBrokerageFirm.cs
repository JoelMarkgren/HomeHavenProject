using HomeHavenAPI.Models;

namespace HomeHavenAPI.Data.Interfaces
{
    public interface IBrokerageFirm
    {
        Task<BrokerageFirm> Get(int id);
        Task<IEnumerable<BrokerageFirm>> GetAll();
    }
}
