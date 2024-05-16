using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HomeHavenAPI.Models
{
	public class FirmRequest
	{
        public int FirmRequestId { get; set; }
        [Required]
		public string FromEmail { get; set; }
		[Required]
		public string ToEmail { get; set; }
		[ForeignKey("Realtor")]
		public int RealtorFirmId { get; set; }
    }
}
