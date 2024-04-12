using HomeHavenAPI.Data.Interfaces;
using HomeHavenAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeHavenAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrokerController : ControllerBase
    {
        private readonly IBroker brokerRepo;

        public BrokerController(IBroker brokerRepo)
        {
            this.brokerRepo = brokerRepo;
        }
        // GET: api/<BrokerController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Broker>>> Get()
        {
            var brokerList = await brokerRepo.GetAllAsync();
            if (brokerList == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(brokerList);
            }

        }

        // GET api/<BrokerController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Broker>> Get(int id)
        {
            var broker = await brokerRepo.GetAsync(id);
            if (broker == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(broker);
            }
        }

        // POST api/<BrokerController>
        [HttpPost]
        public async Task Post([FromBody] Broker broker)
        {
            await brokerRepo.CreateAsync(broker);
        }

        // PUT api/<BrokerController>/5
        [HttpPut("{id}")]
        public async Task<Broker> Put(int id, [FromBody] Broker broker)
        {
            broker.BrokerId = id;
            await brokerRepo.EditAsync(broker);
            return broker;
        }

        // DELETE api/<BrokerController>/5
        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            await brokerRepo.DeleteAsync(id);

        }
    }
}
