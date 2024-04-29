
using HomeHavenBlazorProject.DTOs;
using HomeHavenBlazorProject.Models;

namespace HomeHavenBlazorProject.Services
{
    public interface IResidenceService
    {
        Task<IEnumerable<ResidenceDto>> GetAllAsync();
        Task<ResidenceDto> GetAsync(int id);
    }
}
