using HomeHavenAPI.Data.Interfaces;
using HomeHavenAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeHavenAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrokerageFirmController : ControllerBase
    {
        private readonly IBrokerageFirm brokerageFirmRepo;

        public BrokerageFirmController(IBrokerageFirm brokerageFirmRepo)
        {
            this.brokerageFirmRepo = brokerageFirmRepo;
        }
        // GET: api/<BrokerageFirmController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BrokerageFirm>>> GetAll()
        {
            var firms = await brokerageFirmRepo.GetAll();
            if (firms == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(firms);
            }
            
        }

        // GET api/<BrokerageFirmController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BrokerageFirm>> Get(int id)
        {
            var firm = await brokerageFirmRepo.Get(id);
            if (firm == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(firm);
            }
        }

    }
}
