using HomeHavenAPI.Data.Interfaces;
using HomeHavenAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeHavenAPI.Controllers

    // authors. Joel och Jakob
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly IRegion regionRepo;

        public RegionController(IRegion regionRepo)
        {
            this.regionRepo = regionRepo;
        }
        // GET: api/<RegionController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Region>>> GetAll()
        {
            var regions = await regionRepo.GetAllAsync();
            if (regions == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(regions);
            }
        }

        // GET api/<RegionController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Region>> Get(int id)
        {
            Region region = await regionRepo.GetAsync(id);
            if (region == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(region);
            }
        }
    }
}
