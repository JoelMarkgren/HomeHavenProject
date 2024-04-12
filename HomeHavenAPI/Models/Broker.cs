namespace HomeHavenAPI.Models
{
    public class Broker
    {
        public int Id { get; set; }
        public BrokerageFirm? Firm { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ProfilePictureURL { get; set; }
    }
}
