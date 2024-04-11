namespace HomeHavenAPI.Models
{
    
    public class Residence
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public string Address { get; set; }
        public Region Region { get; set; }
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
        public Broker Broker { get; set; }
    }
}
