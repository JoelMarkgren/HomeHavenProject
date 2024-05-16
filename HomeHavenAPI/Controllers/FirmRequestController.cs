using HomeHavenAPI.Data.Interfaces;
using HomeHavenAPI.Dtos;
using HomeHavenAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomeHavenAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FirmRequestController : ControllerBase
	{
		private readonly IFirmRequest firmRequestRepo;

		public FirmRequestController(IFirmRequest firmRequestRepo)
		{
			this.firmRequestRepo = firmRequestRepo;
		}

		[HttpPost]
		public async Task Post([FromBody] FirmRequest firmRequest)
		{
			await firmRequestRepo.CreateAsync(firmRequest);
		}

		[HttpGet("GetInvites/{ToEmail}")]
		public async Task<ActionResult<IEnumerable<FirmRequest>>> GetInvites(string ToEmail)
		{
			var inviteList = await firmRequestRepo.GetAllInivtesAsync(ToEmail);
			if (inviteList == null)
			{
				return NotFound();
			}
			else
			{
				return Ok(inviteList);
			}

		}

		[HttpGet("GetRequests/{FromEmail}")]
		public async Task<ActionResult<IEnumerable<FirmRequest>>> GetRequests(string FromEmail)
		{
			var inviteList = await firmRequestRepo.GetAllRequestsAsync(FromEmail);
			if (inviteList == null)
			{
				return NotFound();
			}
			else
			{
				return Ok(inviteList);
			}
		}

		[HttpDelete("{id}")]
		public async Task Delete(int id)
		{
			await firmRequestRepo.DeleteAsync(id);
		}

	}
}
