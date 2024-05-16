using System.ComponentModel.DataAnnotations;

namespace HomeHavenBlazorProject.Models
{
	public class FirmRequest
	{
        public int FirmRequestId { get; set; }
        [Required]
		public string FromEmail { get; set; }
		[Required]
		public string ToEmail { get; set; }
		[Required]
		public int RealtorFirmId { get; set; }
	}
}
