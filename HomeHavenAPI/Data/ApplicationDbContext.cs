using HomeHavenAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace HomeHavenAPI.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		public DbSet<Realtor> Realtors { get; set; }
		public DbSet<RealtorFirm> Firms { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Region> Regions { get; set; }
		public DbSet<Residence> Residences { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>().HasData(
				new Category() { CategoryId = 1, CategoryName = "Villa" },
				new Category() { CategoryId = 2, CategoryName = "Lägenhet" },
				new Category() { CategoryId = 3, CategoryName = "RadHus" },
				new Category() { CategoryId = 4, CategoryName = "FritidsBoende" },
				new Category() { CategoryId = 5, CategoryName = "Tomt" }
				);

			modelBuilder.Entity<Region>().HasData(
				new Region() { RegionId = 1, County = "Stockholm", Township = "Sollentuna" },
				new Region() { RegionId = 2, County = "Uppsala", Township = "Östhammar" },
				new Region() { RegionId = 3, County = "Jönköpings", Township = "Gislaved" },
				new Region() { RegionId = 4, County = "Kalmar", Township = "Torsås" },
				new Region() { RegionId = 5, County = "Blekinge", Township = "Karlskrona" }
				);

			modelBuilder.Entity<RealtorFirm>().HasData(
				new RealtorFirm() { RealtorFirmId = 1, Descrpition = "En mäklarfirm med fokus på att göra drömmar till verklighet för kunder genom att matcha dem med sitt perfekta hem.", FirmName = "Dream Home Realty", LogoURL = "URL" },
				new RealtorFirm() { RealtorFirmId = 2, Descrpition = "Specialiserade på lyxiga och exklusiva fastigheter, erbjuder Elite Properties en förstklassig service för kunder som söker det bästa av det bästa.", FirmName = "Elite Properties", LogoURL = "URL" },
				new RealtorFirm() { RealtorFirmId = 3, Descrpition = "Med starka förbindelser och expertis inom fastighetsmarknaden, strävar Prime Real Estate Solutions efter att hjälpa kunder att hitta de mest lönsamma fastighetsaffärerna.", FirmName = "Prime Real Estate Solutions", LogoURL = "URL" },
				new RealtorFirm() { RealtorFirmId = 4, Descrpition = "Fokuserar på att skapa en \"näste\" åt sina kunder där de kan känna sig hemma och bekväma i den stadsmiljö de älskar.", FirmName = "Urban Nest Realty", LogoURL = "URL" },
				new RealtorFirm() { RealtorFirmId = 5, Descrpition = "Tar sina kunder till nya horisonter genom att guida dem genom köp- och säljprocessen med en personlig och professionell approach.", FirmName = "Horizon Homes Real Estate", LogoURL = "URL" }
				);

			modelBuilder.Entity<Realtor>().HasData(
				new Realtor() { RealtorId = 1, FirstName = "Sofia", LastName = "Andersson", Email = "sofia.andersson@example.com", PhoneNumber = "070-1234567", ProfilePictureURL = "URL", RealtorFirmId = 1 },
				new Realtor() { RealtorId = 2, FirstName = "Erik", LastName = "Svensson", Email = "erik.svensson@example.com", PhoneNumber = "073-9876543", ProfilePictureURL = "URL", RealtorFirmId = 3 },
				new Realtor() { RealtorId = 3, FirstName = "Emma", LastName = "Johansson", Email = "emma.johansson@example.com", PhoneNumber = "076-1112233", ProfilePictureURL = "URL", RealtorFirmId = 2 },
				new Realtor() { RealtorId = 4, FirstName = "Anders", LastName = "Karlsson", Email = "anders.karlsson@example.com", PhoneNumber = "072-5554441", ProfilePictureURL = "URL", RealtorFirmId = 2 },
				new Realtor() { RealtorId = 5, FirstName = "Linnea", LastName = "Lindgren", Email = "linnea.lindgren@example.com", PhoneNumber = "074-8889990", ProfilePictureURL = "URL", RealtorFirmId = 5 }
				);

			modelBuilder.Entity<Residence>().HasData(
				new Residence() { ResidenceId = 1, Address = "Sveavägen 42", BiArea = 20, LandArea = 500, LivingArea = 120, ConstructionYear = 2004, StartingPrice =  2000000, MonthlyFee = 4000, OperatingCost = 50000, PictureListURL = ["https://gotenehus.se/app/uploads/2022/09/puff-vassholm-lada-1344x896.jpg"], RoomCount = 5, CategoryId = 1, RealtorId = 5, RegionId =  1, ResidenceDescription = "Modern lägenhet med öppen planlösning och balkong belägen i centrala stan." },
				new Residence() { ResidenceId = 2, Address = "Storgatan 12", BiArea = 30, LandArea = 0, LivingArea = 100, ConstructionYear = 2000, StartingPrice =  1250000, MonthlyFee = 6500, OperatingCost = 24500, PictureListURL = ["https://www.brahus.se/upload/house/1031629571.jpg"], RoomCount = 3, CategoryId = 2, RealtorId = 4, RegionId =  2, ResidenceDescription = "Charmigt radhus med trädgård och garage i lugnt bostadsområde nära naturen." },
				new Residence() { ResidenceId = 3, Address = "Strandvägen 7", BiArea = 0, LandArea = 1000, LivingArea = 250, ConstructionYear = 2018, StartingPrice =  3000000, MonthlyFee = 4250, OperatingCost = 32400, PictureListURL = ["https://hjaltevadshus.se/app/uploads/2022/10/nyckelfardiga-vitsippan.jpg"], RoomCount = 6, CategoryId = 3, RealtorId = 3, RegionId =  3, ResidenceDescription = "Funkisvilla med pool och havsutsikt på exklusiv adress vid kusten." },
				new Residence() { ResidenceId = 4, Address = "Norra Vallgatan 14", BiArea = 15, LandArea = 625, LivingArea = 130, ConstructionYear = 2009, StartingPrice =  2230000, MonthlyFee = 7000, OperatingCost = 31500, PictureListURL = ["https://www.osloguiden.se/wp-content/uploads/2015/04/Pilestredet.jpg"], RoomCount = 4, CategoryId = 4, RealtorId = 3, RegionId =  2, ResidenceDescription = "Gammal gård renoverad till lyxigt boende med generösa sällskapsytor och stor trädgård." },
				new Residence() { ResidenceId = 5, Address = "Östra Hamngatan 3", BiArea = 50, LandArea = 200, LivingArea = 120, ConstructionYear = 1972, StartingPrice =  1400000, MonthlyFee = 3750, OperatingCost = 20500, PictureListURL = ["https://www.ekonomifokus.se/wp-content/uploads/2019/01/Vad-ingar-vid-kop-och-salj-av-fastighet-och-hus-e1547480095379.jpg"], RoomCount = 5, CategoryId = 5, RealtorId = 1, RegionId =  5, ResidenceDescription = "Lägenhet i nybyggd bostadsrättsförening med gemensam takterrass och närhet till shopping och kommunikationer." }


				);

		}

	}
}
