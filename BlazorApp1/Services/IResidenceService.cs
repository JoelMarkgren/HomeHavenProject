using HomeHavenBlazorProject.Models;

namespace HomeHavenBlazorProject.Services
{
    public interface IResidenceService
    {
        Task<IEnumerable<Residence>> GetAllAsync();
        Task<Residence> GetAsync(int id);
    }
}
