using System.ComponentModel.DataAnnotations.Schema;

namespace HomeHavenAPI.Models
{

    public class Residence
    {
        public int ResidenceId { get; set; }
        public int CategoryId { get; set; }
        public string Address { get; set; }
        public int RegionId { get; set; }
        public int StartingPrice { get; set; }
        public int LivingArea { get; set; }
        public int BiArea { get; set; }
        public int LandArea { get; set; }
        public string ResidenceDescription { get; set; }
        public decimal RoomCount { get; set; }
        public decimal? MonthlyFee { get; set; }
        public decimal OperatingCost { get; set; }
        public int ConstructionYear { get; set; }
        public List<string> PictureListURL { get; set; }
        public int BrokerId { get; set; }
    }
}
