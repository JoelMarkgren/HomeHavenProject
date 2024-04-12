using HomeHavenAPI.Data.Interfaces;
using HomeHavenAPI.Models;

namespace HomeHavenAPI.Data.Repos
{
    public class BrokerRepository : IBroker
    {
        public Task<Broker> Create()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Broker> Edit(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Broker> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Broker>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
