using System.ComponentModel.DataAnnotations.Schema;

namespace HomeHavenAPI.Models
{
    public class ResidenceDto
    {
        public int ResidenceId { get; set; }
        public int CategoryId { get; set; }
		public string CategoryName { get; set; }
		public string Address { get; set; }
        public int RegionId { get; set; }
		public int StartingPrice { get; set; }
        public int LivingArea { get; set; }
        public decimal RoomCount { get; set; }
        public string MainPicture { get; set; }
		public Category ResidenceCategory { get; set; }
		public Region ResidenceRegion { get; set; }
		public Realtor ResidenceRealtor { get; set; }
	}
}
