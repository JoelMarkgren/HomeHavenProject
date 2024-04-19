using HomeHavenAPI.Data.Interfaces;
using HomeHavenAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeHavenAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RealtorFirmController : ControllerBase
    {
        private readonly IRealtorFirm RealtorFirmRepo;

        public RealtorFirmController(IRealtorFirm RealtorFirmRepo)
        {
            this.RealtorFirmRepo = RealtorFirmRepo;
        }
		// GET: api/<RealtorFirmController>
		[HttpGet]
        public async Task<ActionResult<IEnumerable<RealtorFirm>>> GetAll()
        {
            var firms = await RealtorFirmRepo.GetAllAsync();
            if (firms == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(firms);
            }
            
        }

		// GET api/<RealtorFirmController>/5
		[HttpGet("{id}")]
        public async Task<ActionResult<RealtorFirm>> Get(int id)
        {
            var firm = await RealtorFirmRepo.GetAsync(id);
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
