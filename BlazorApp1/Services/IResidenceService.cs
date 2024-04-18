using HomeHavenAPI.Models;
using HomeHavenBlazorProject.Models;

namespace HomeHavenBlazorProject.Services
{
    public interface IResidenceService
    {
        Task<IEnumerable<ResidenceDto>> GetAllAsync();
        Task<Residence> GetAsync(int id);
    }
}
