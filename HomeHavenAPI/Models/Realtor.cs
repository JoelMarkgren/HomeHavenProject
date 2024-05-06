using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HomeHavenAPI.Models
{
	public class Realtor : IdentityUser
	{
		public int? RealtorId { get; set; }
		[ForeignKey("RealtorFirm")]
		public int? RealtorFirmId { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? ProfilePictureURL { get; set; }
		[JsonIgnore]
		public RealtorFirm? MyRealtorFirm { get; set; }
	}
}
