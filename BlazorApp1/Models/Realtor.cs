using static System.Net.WebRequestMethods;

namespace HomeHavenBlazorProject.Models
{
    public class Realtor
    {
        public string RealtorId { get; set; }
        public int RealtorFirmId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
		public string? PhoneNumber { get; set; }
        public string? ProfilePictureURL { get; set; } 
    }
}
