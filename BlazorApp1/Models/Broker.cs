﻿namespace HomHavenBlazorProject.Models
{
    public class Broker
    {
        public int BrokerId { get; set; }
        public int BrokerageFirmId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ProfilePictureURL { get; set; }
    }
}