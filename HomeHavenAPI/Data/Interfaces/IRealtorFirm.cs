using HomeHavenAPI.Models;

namespace HomeHavenAPI.Data.Interfaces
{
    public interface IRealtorFirm
    {
        Task<RealtorFirm> GetAsync(int id);
        Task<IEnumerable<RealtorFirm>> GetAllAsync();
    }
}
