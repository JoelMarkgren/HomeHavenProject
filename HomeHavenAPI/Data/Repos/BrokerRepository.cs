using HomeHavenAPI.Data.Interfaces;
using HomeHavenAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace HomeHavenAPI.Data.Repos
{
    public class BrokerRepository : IBroker
    {
        private readonly ApplicationDbContext applicationDbContext;

        public BrokerRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task CreateAsync(Broker broker)
        {           
            await applicationDbContext.Brokers.AddAsync(broker);
            await applicationDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var broker = await applicationDbContext.Brokers.FindAsync(id);
            if(broker != null)
            {
                applicationDbContext.Brokers.Remove(broker);
                await applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<Broker> EditAsync(Broker broker)
        {
                applicationDbContext.Brokers.Update(broker);
                await applicationDbContext.SaveChangesAsync();
                return broker;
        }

        public async Task<Broker> GetAsync(int id)
        {
            return await applicationDbContext.Brokers.FindAsync(id);
        }

        public async Task<IEnumerable<Broker>> GetAllAsync()
        {
            return await applicationDbContext.Brokers.ToListAsync();
        }
    }
}
