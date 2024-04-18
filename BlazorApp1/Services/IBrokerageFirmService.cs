using HomeHavenBlazorProject.Models;

namespace HomeHavenBlazorProject.Services
{
    public interface IBrokerageFirmService
    {
        Task<IEnumerable<BrokerageFirm>> GetAllAsync();
        Task<BrokerageFirm> GetAsync(int id);
    }
}
