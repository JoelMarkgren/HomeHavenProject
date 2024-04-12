using HomeHavenAPI.Models;

namespace HomeHavenAPI.Data.Interfaces
{
    public interface ICategory
    {
        Task<Category> GetAsync(int id);
        Task<IEnumerable<Category>> GetAllAsync();
    }
}
