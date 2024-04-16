using HomHavenBlazorProject.Models;

namespace HomHavenBlazorProject.Services
{
    public interface IBrokerageFirmService
    {
        Task<IEnumerable<BrokerageFirm>> GetAllAsync();
        Task<BrokerageFirm> GetAsync(int id);
    }
}
