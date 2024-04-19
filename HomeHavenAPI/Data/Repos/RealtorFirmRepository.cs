using HomeHavenAPI.Data.Interfaces;
using HomeHavenAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeHavenAPI.Data.Repos
{
    public class RealtorFirmRepository : IRealtorFirm
    {
        private readonly ApplicationDbContext applicationDbContext;

        public RealtorFirmRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task<RealtorFirm> GetAsync(int id)
        {
            return await applicationDbContext.Firms.FindAsync(id);
        }

        public async Task<IEnumerable<RealtorFirm>> GetAllAsync()
        {
            var firms = await applicationDbContext.Firms.ToListAsync();
            return firms;
        }
    }
}
