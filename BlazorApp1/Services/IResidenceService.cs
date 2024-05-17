using HomeHavenBlazorProject.Models;

namespace HomeHavenBlazorProject.Services
{
    public interface IResidenceService
    {
        Task<IEnumerable<Residence>> GetAllAsync();
        Task<Residence> GetAsync(int id);
        Task<Residence> CreateAsync(Residence residence);
        Task UpdateAsync(Residence residence);
        Task DeleteAsync(Residence residence);
        Task<IEnumerable<Residence>> GetRealtorResidencesAsync(string id);
    }
}
