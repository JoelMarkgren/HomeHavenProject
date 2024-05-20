using HomeHavenAPI.Data.Interfaces;
using HomeHavenAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeHavenAPI.Data.Repos
{
	//Author Joel,Jakob
	public class RegionRepository : IRegion
    {
        private readonly ApplicationDbContext applicationDbContext;
        public RegionRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task<Region> GetAsync(int id)
        {
            return await applicationDbContext.Regions.FindAsync(id);
        }
        public async Task<IEnumerable<Region>> GetAllAsync()
        {
            var regions = await applicationDbContext.Regions.ToListAsync();
            return regions;
        }
    }
}
