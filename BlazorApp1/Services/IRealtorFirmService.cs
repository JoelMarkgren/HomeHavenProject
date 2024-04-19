using HomeHavenBlazorProject.Models;

namespace HomeHavenBlazorProject.Services
{
    public interface IRealtorFirmService
    {
        Task<IEnumerable<RealtorFirm>> GetAllAsync();
        Task<RealtorFirm> GetAsync(int id);
    }
}
