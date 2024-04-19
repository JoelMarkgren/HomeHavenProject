using HomeHavenAPI.Data.Interfaces;
using HomeHavenAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace HomeHavenAPI.Data.Repos
{
    public class RealtorRepository : IRealtor
    {
        private readonly ApplicationDbContext applicationDbContext;

        public RealtorRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task CreateAsync(Realtor realtor)
        {           
            await applicationDbContext.Realtors.AddAsync(realtor);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var realtor = await applicationDbContext.Realtors.FindAsync(id);
            if(realtor != null)
            {
                applicationDbContext.Realtors.Remove(realtor);
                await applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<Realtor> EditAsync(Realtor realtor)
        {
                applicationDbContext.Realtors.Update(realtor);
                await applicationDbContext.SaveChangesAsync();
                return realtor;
        }

        public async Task<Realtor> GetAsync(int id)
        {
            return await applicationDbContext.Realtors.FindAsync(id);
        }

        public async Task<IEnumerable<Realtor>> GetAllAsync()
        {
            return await applicationDbContext.Realtors.ToListAsync();
        }
    }
}
