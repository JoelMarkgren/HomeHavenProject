using System.ComponentModel.DataAnnotations.Schema;

namespace HomeHavenAPI.Models
{
    public class Broker
    {
        public int BrokerId { get; set; }
        [ForeignKey("BrokerageFirmIdId")]
        public int BrokerageFirmId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ProfilePictureURL { get; set; }
    }
}
