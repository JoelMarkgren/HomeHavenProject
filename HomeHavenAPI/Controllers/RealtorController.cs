﻿using HomeHavenAPI.Data.Interfaces;
using HomeHavenAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeHavenAPI.Controllers
{
	//Author Joel,Jakob
	[Route("api/[controller]")]
    [ApiController]
    public class RealtorController : ControllerBase
    {
        private readonly IRealtor realtorRepo;

        public RealtorController(IRealtor realtorRepo)
        {
            this.realtorRepo = realtorRepo;
        }
        // GET: api/<RealtorController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Realtor>>> Get()
        {
            var realtorList = await realtorRepo.GetAllAsync();
            if (realtorList == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(realtorList);
            }

        }

        // GET api/<RealtorController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Realtor>> Get(string id)
        {
            var realtor = await realtorRepo.GetAsync(id);
            if (realtor == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(realtor);
            }
        }

        // POST api/<RealtorController>
        [HttpPost]
        public async Task Post([FromBody] Realtor realtor)
        {
            await realtorRepo.CreateAsync(realtor);
        }

        // PUT api/<RealtorController>/5
        [HttpPut("{id}")]
        public async Task<Realtor> Put(string id, [FromBody] Realtor realtor)
        {

            realtor.Id = id;
            await realtorRepo.EditAsync(realtor, id);
            return realtor;

        }

        // DELETE api/<RealtorController>/5
        [HttpDelete("{id}")]
        public async void Delete(string id)
        {
            await realtorRepo.DeleteAsync(id);

        }
    }
}
