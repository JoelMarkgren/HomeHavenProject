using HomeHavenAPI.Data.Interfaces;
using HomeHavenAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeHavenAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategory categoryRepo;

        public CategoryController(ICategory categoryRepo)
        {
            this.categoryRepo = categoryRepo;
        }
        // GET: api/<CategoryController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetAsync()
        {
            var categories = await categoryRepo.GetAll();
            if (categories == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(categories);
            }
        }
        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> Get(int id)
        {
            Category category = await categoryRepo.Get(id);
            if (category == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(category);
            }
        }
    }
}
