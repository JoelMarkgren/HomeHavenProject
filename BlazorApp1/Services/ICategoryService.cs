using HomeHavenBlazorProject.Models;

namespace HomeHavenBlazorProject.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category> GetAsync(int id);
    }
}
