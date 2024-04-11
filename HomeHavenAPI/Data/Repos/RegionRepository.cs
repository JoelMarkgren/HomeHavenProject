using HomeHavenAPI.Data.Interfaces;
using HomeHavenAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeHavenAPI.Data.Repos
{
    public class RegionRepository : IRegion
    {
        private readonly ApplicationDbContext applicationDbContext;
        public RegionRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task<Region> Get(int id)
        {
            return await applicationDbContext.Regions.FindAsync(id);
        }
        public async Task<IEnumerable<Region>> GetAll()
        {
            var regions = await applicationDbContext.Regions.ToListAsync();
            return regions;
        }
    }
}
