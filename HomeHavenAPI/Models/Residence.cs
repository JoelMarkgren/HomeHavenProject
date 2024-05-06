using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HomeHavenAPI.Models
{

    public class Residence
    {
        public int ResidenceId { get; set; }
        public string Address { get; set; }
        public int StartingPrice { get; set; }
        public int LivingArea { get; set; }
        public int BiArea { get; set; }
        public int LandArea { get; set; }
        public string ResidenceDescription { get; set; }
        public int RoomCount { get; set; }
        public int? MonthlyFee { get; set; }
        public int OperatingCost { get; set; }
        public int ConstructionYear { get; set; }
        public List<string>? PictureListURL { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        [ForeignKey("Region")]
        public int RegionId { get; set; }
        [ForeignKey("Realtor")]
        public string RealtorId { get; set; }

        [JsonIgnore]
        public Category? ResidenceCategory { get; set; }
        [JsonIgnore]
        public Region? ResidenceRegion { get; set; }
        [JsonIgnore]
        public Realtor? ResidenceRealtor { get; set; }

    }
}
