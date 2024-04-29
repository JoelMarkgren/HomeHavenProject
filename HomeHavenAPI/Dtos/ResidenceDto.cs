using System.ComponentModel.DataAnnotations.Schema;
using HomeHavenAPI.Models;

namespace HomeHavenAPI.Dtos
{
    public class ResidenceDto
    {
		public int ResidenceId { get; set; }
		public string Address { get; set; }
		public int StartingPrice { get; set; }
		public int LivingArea { get; set; }
		public int BiArea { get; set; }
		public int LandArea { get; set; }
		public string ResidenceDescription { get; set; }
		public int RoomCount { get; set; }
		public decimal? MonthlyFee { get; set; }
		public decimal OperatingCost { get; set; }
		public int ConstructionYear { get; set; }
		public List<string> PictureListURL { get; set; }

		public Category? ResidenceCategory { get; set; }
		public Region? ResidenceRegion { get; set; }
		public Realtor? ResidenceRealtor { get; set; }
	}
}
