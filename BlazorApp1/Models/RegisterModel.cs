﻿using System.ComponentModel.DataAnnotations;

namespace HomeHavenBlazorProject.Models
{
	public class RegisterModel
	{
        public int RealtorFirmId { get; set; }
        [Required]
		public string UserName { get; set; }
		[Required]
		[EmailAddress]
		public string Email { get; set; }
		[Required]
		public string Password { get; set; }
		[Required]
		[Compare("Password", ErrorMessage = "Lösenorden stämmer inte överens")]
		public string ConfirmPassword { get; set; }
		[Required]
		public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }
	}
}
