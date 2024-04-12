using HomeHavenAPI.Models;

namespace HomeHavenAPI.Data.Interfaces
{
    public interface IBrokerageFirm
    {
        Task<BrokerageFirm> GetAsync(int id);
        Task<IEnumerable<BrokerageFirm>> GetAllAsync();
    }
}
