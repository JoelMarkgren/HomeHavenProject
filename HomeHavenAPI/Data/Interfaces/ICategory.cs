using HomeHavenAPI.Models;

namespace HomeHavenAPI.Data.Interfaces
{
    public interface ICategory
    {
        Task<Category> Get(int id);
        Task<IEnumerable<Category>> GetAll();
    }
}
