using System.ComponentModel.DataAnnotations.Schema;

namespace HomeHavenAPI.Models
{
    
    public class Residence
    {
        public int ResidenceId { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public string Address { get; set; }
        [ForeignKey("RegionId")]
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
        [ForeignKey("BrokerId")]
        public int BrokerId { get; set; }
    }
}
