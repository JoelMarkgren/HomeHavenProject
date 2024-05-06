using HomeHavenAPI.Data.Interfaces;
using HomeHavenAPI.Dtos;
using HomeHavenAPI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HomeHavenAPI.Controllers
{
	[Route("api/account")]
	[ApiController]
	public class AccountController : ControllerBase
	{
		private readonly UserManager<Realtor> userManager;
		private readonly ITokenService tokenService;
		private readonly SignInManager<Realtor> signInManager;

		public AccountController(UserManager<Realtor> userManager, ITokenService tokenService, SignInManager<Realtor> signInManager)
		{
			this.userManager = userManager;
			this.tokenService = tokenService;
			this.signInManager = signInManager;
		}

		[HttpPost("login")]
		public async Task<IActionResult> Login(LoginDto loginDto)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			var user = await userManager.Users.FirstOrDefaultAsync(x => x.UserName == loginDto.UserName.ToLower());
			if (user == null) return Unauthorized("Invalid username!");

			var result = await signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);

			if (!result.Succeeded) return Unauthorized("Username not found and/or password incorrect");

			return Ok(
				new NewUserDto
				{
					UserName = user.UserName,
					Email = user.Email,
					Token = tokenService.CreateToken(user)
				});
		}

		[HttpPost("register")]
		public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
		{
			try
			{
				if (!ModelState.IsValid)
					return BadRequest(ModelState);

				var realtor = new Realtor
				{
					UserName = registerDto.UserName,
					Email = registerDto.Email,
					FirstName = registerDto.FirstName,
					LastName = registerDto.LastName
				};

				var createdUser = await userManager.CreateAsync(realtor, registerDto.Password);

				if (createdUser.Succeeded)
				{
					var roleResult = await userManager.AddToRoleAsync(realtor, "User");
					if (roleResult.Succeeded)
					{
						return Ok(
							new NewUserDto
							{
								UserName = realtor.UserName,
								Email = realtor.Email,
								Token = tokenService.CreateToken(realtor),
								FirstName = realtor.FirstName,
								LastName = realtor.LastName
							}
						);
					}
					else
					{
						return StatusCode(500, roleResult.Errors);
					}
				}
				else
				{
					return StatusCode(500, createdUser.Errors);
				}
			}
			catch (Exception e)
			{
				return StatusCode(500, e);
			}
		}
	}
}

