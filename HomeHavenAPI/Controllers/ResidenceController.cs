using AutoMapper;
using HomeHavenAPI.Data.Interfaces;
using HomeHavenAPI.Dtos;
using HomeHavenAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeHavenAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ResidenceController : ControllerBase
	{
		private readonly IResidence residenceRepo;
		private readonly IMapper mapper;
		private readonly IRealtor realtorRepo;
		private readonly ICategory catRepo;
		private readonly IRegion regionRepo;

		public ResidenceController(IResidence residenceRepo, IMapper mapper)
		{
			this.residenceRepo = residenceRepo;
			this.mapper = mapper;
		}


		// GET api/<ResidenceController>/5
		[HttpGet("{id}")]
		public async Task<ActionResult<Residence>> Get(int id)
		{
			try
			{
				var resi = await residenceRepo.GetAsync(id);

				if (resi == null)
				{
					return BadRequest();
				}
				else
				{
					ResidenceDto residenceDto = mapper.Map<ResidenceDto>(resi);

					return Ok(residenceDto);  //Varför är return inte Dto
				}

			}

			catch (Exception)
			{
				return StatusCode(StatusCodes.Status500InternalServerError,
								"Error retrieving data from the database");

			}

		}

        [HttpGet("GetRealtorResideneces/{realtorId}")]
        public async Task<ActionResult<Residence>> GetRealtorResidences(string realtorId)
		{
			try
			{
                var realtorResidences = await residenceRepo.GetListAsync(realtorId);
				if (realtorResidences == null)
				{
					return NotFound();
				}
				else
				{
					return Ok(realtorResidences);
				}
			}

			catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");

            }

        }


        // POST api/<ResidenceController>
        [HttpPost]
		public async Task Post([FromBody] Residence residence)
		{
			var residenceMap = mapper.Map<Residence>(residence);
			await residenceRepo.CreateAsync(residenceMap);
		}

		// PUT api/<ResidenceController>/5
		[HttpPut("{id}")]
		public async Task Put(int id, [FromBody] Residence residence)
		{
			residence.ResidenceId = id;
			await residenceRepo.EditAsync(residence);
		}

		// DELETE api/<ResidenceController>/5
		[HttpDelete("{id}")]
		public async Task Delete(int id)
		{
			await residenceRepo.DeleteAsync(id);
		}

		//GET: api/<ResidenceController>
		[HttpGet]
		public async Task<ActionResult<IEnumerable<ResidenceDto>>> Get()
		{
			var residences = await residenceRepo.GetAllAsync();
			return Ok(residences.Select(resi => mapper.Map<ResidenceDto>(resi)));
		}
	}
}
