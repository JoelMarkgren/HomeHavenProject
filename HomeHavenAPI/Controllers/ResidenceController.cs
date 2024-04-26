﻿using AutoMapper;
using HomeHavenAPI.Data.Interfaces;
using HomeHavenAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeHavenAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResidenceController : ControllerBase
    {
        private readonly IResidence residenceRepo;
        private readonly IMapper mapper;

        public ResidenceController(IResidence residenceRepo, IMapper mapper)
        {
            this.residenceRepo = residenceRepo;
            this.mapper = mapper;
        }
      
        // GET api/<ResidenceController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Residence>> Get(int id)
        {
            var residence = await residenceRepo.GetAsync(id);
            if (residence == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(residence);
            }

        }

        // GET api/<RealtorController>/GetResidences/3
        [HttpGet("GetResidences/{realtorId}")]
        public async Task<ActionResult<Realtor>> GetResidences(int realtorId)
        {
            var realtorsResidences = await residenceRepo.GetRealtorsResidencesAsync(realtorId);
            if (realtorsResidences == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(realtorsResidences);
            }
        }

        // POST api/<ResidenceController>
        [HttpPost]
        public async Task Post([FromBody] Residence residence)
        {
            await residenceRepo.CreateAsync(residence);  
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
        public async Task<ActionResult<IEnumerable<Residence>>> Get()
        {
            var residences = await residenceRepo.GetAllAsync();
            return Ok(residences.Select(resi => mapper.Map<ResidenceDto>(resi)));
        }
    }
}
