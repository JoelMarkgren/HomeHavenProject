using HomeHavenAPI.Data.Interfaces;
using HomeHavenAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeHavenAPI.Data.Repos
{
    public class ResidenceRepository : IResidence
    {
        private readonly ApplicationDbContext applicationDbContext;

        public ResidenceRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task CreateAsync(Residence residence)
        {
            await applicationDbContext.Residences.AddAsync(residence);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var residence = await applicationDbContext.Residences.FindAsync(id);
            if(residence != null)
            {
                applicationDbContext.Residences.Remove(residence);
                await applicationDbContext.SaveChangesAsync();
            }

        }

        public async Task<Residence> EditAsync(Residence residence)
        {
            applicationDbContext.Residences.Update(residence);
            await applicationDbContext.SaveChangesAsync();
            return residence;
        }

        public async Task<IEnumerable<Residence>> GetAllAsync()
        {
            //var residence = await applicationDbContext.Residences
                //.Include(r => r.ResidenceRegion)
                
            return await applicationDbContext.Residences
                .Include(r =>r.ResidenceCategory)
                .ToListAsync();
        }

        public async Task<Residence> GetAsync(int id)
        {
            return await applicationDbContext.Residences.FindAsync(id);
        }
    }
}
