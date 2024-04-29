using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HomeHavenAPI.Models
{
    public class Realtor
    {
        public int RealtorId { get; set; }       
        public int RealtorFirmId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ProfilePictureURL { get; set; }
		[ForeignKey("RealtorFirm")]
		public RealtorFirm? MyRealtorFirm { get; set; }
    }
}
