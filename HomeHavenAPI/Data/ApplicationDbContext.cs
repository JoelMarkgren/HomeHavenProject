﻿using HomeHavenAPI.Models;
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
                new Region() { RegionId = 5, County = "Blekinge", Township = "Karlskrona" },
                new Region() { RegionId = 6, County = "Västerbotten", Township = "Umeå" },
                new Region() { RegionId = 7, County = "Stockholm", Township = "Ekerö" },
                new Region() { RegionId = 8, County = "Jämtland", Township = "Östersund" },
                new Region() { RegionId = 9, County = "Skåne", Township = "Malmö" },
                new Region() { RegionId = 10, County = "Skåne", Township = "Hörby" },
                new Region() { RegionId = 12, County = "Stockholm", Township = "Järfälla" },
                new Region() { RegionId = 14, County = "Stockholm", Township = "Botkyrka" },
                new Region() { RegionId = 15, County = "Stockholm", Township = "Solna" },
                new Region() { RegionId = 16, County = "Stockholm", Township = "Lidingö" },
                new Region() { RegionId = 17, County = "Uppsala", Township = "Håbå" },
                new Region() { RegionId = 19, County = "Uppsala", Township = "Knivsta" },
                new Region() { RegionId = 20, County = "Uppsala", Township = "Enköping" },
                new Region() { RegionId = 21, County = "Uppsala", Township = "Älvkarleby" },
                new Region() { RegionId = 22, County = "Uppsala", Township = "Tierp" },
                new Region() { RegionId = 23, County = "Södermanland", Township = "Vingåker" },
                new Region() { RegionId = 24, County = "Södermanland", Township = "Gnesta" },
                new Region() { RegionId = 25, County = "Södermanland", Township = "Nyköping" },
                new Region() { RegionId = 26, County = "Södermanland", Township = "Oxelösund" },
                new Region() { RegionId = 27, County = "Södermanland", Township = "Flen" },
                new Region() { RegionId = 28, County = "Södermanland", Township = "Katrineholm" },
                new Region() { RegionId = 29, County = "Södermanland", Township = "Eskilstuna" },
                new Region() { RegionId = 30, County = "Södermanland", Township = "Strängnäs" },
                new Region() { RegionId = 31, County = "Södermanland", Township = "Trosa" },
                new Region() { RegionId = 32, County = "Östergötland", Township = "Ödeshög" },
                new Region() { RegionId = 33, County = "Östergötland", Township = "Ydre" },
                new Region() { RegionId = 34, County = "Östergötland", Township = "Kinda" },
                new Region() { RegionId = 35, County = "Östergötland", Township = "Boxholm" },
                new Region() { RegionId = 36, County = "Östergötland", Township = "Åtvidaberg" },
                new Region() { RegionId = 37, County = "Östergötland", Township = "Finspång" },
                new Region() { RegionId = 38, County = "Östergötland", Township = "Valdemarsvik" },
                new Region() { RegionId = 39, County = "Östergötland", Township = "Linköping" },
                new Region() { RegionId = 41, County = "Östergötland", Township = "Norrköping" },
                new Region() { RegionId = 42, County = "Östergötland", Township = "Söderköping" },
                new Region() { RegionId = 43, County = "Östergötland", Township = "Motala" },
                new Region() { RegionId = 44, County = "Östergötland", Township = "Vadstena" },
                new Region() { RegionId = 45, County = "Östergötland", Township = "Mjölby" },
                new Region() { RegionId = 46, County = "Jönköping", Township = "Aneby" },
                new Region() { RegionId = 47, County = "Jönköping", Township = "Gnosjö" },
                new Region() { RegionId = 48, County = "Jönköping", Township = "Mullsjö" },
                new Region() { RegionId = 49, County = "Jönköping", Township = "Habo" },
                new Region() { RegionId = 51, County = "Jönköping", Township = "Vaggeryd" },
                new Region() { RegionId = 52, County = "Jönköping", Township = "Jönköping" },
                new Region() { RegionId = 53, County = "Jönköping", Township = "Nässjö" },
                new Region() { RegionId = 55, County = "Jönköping", Township = "Sävsjö" },
                new Region() { RegionId = 56, County = "Jönköping", Township = "Vetlanda" },
                new Region() { RegionId = 57, County = "Jönköping", Township = "Eksjö" },
                new Region() { RegionId = 58, County = "Jönköping", Township = "Tranås" },
                new Region() { RegionId = 59, County = "Kronoberg", Township = "Uppvidinge" },
                new Region() { RegionId = 60, County = "Kronoberg", Township = "Lessebo" },
                new Region() { RegionId = 61, County = "Kronoberg", Township = "Tingsryd" },
                new Region() { RegionId = 62, County = "Kronoberg", Township = "Alvesta" },
                new Region() { RegionId = 63, County = "Kronoberg", Township = "Älmhult" },
                new Region() { RegionId = 64, County = "Kronoberg", Township = "Markaryd" },
                new Region() { RegionId = 65, County = "Kronoberg", Township = "Växsjö" },
                new Region() { RegionId = 66, County = "Kronoberg", Township = "Ljungby" },
                new Region() { RegionId = 67, County = "Kalmar", Township = "Högsby" },
                new Region() { RegionId = 68, County = "Uppsala", Township = "Heby" },
                new Region() { RegionId = 69, County = "Uppsala", Township = "Uppsala" },
                new Region() { RegionId = 70, County = "Kalmar", Township = "Mörbylånga" },
                new Region() { RegionId = 71, County = "Kalmar", Township = "Hultsfred" },
                new Region() { RegionId = 72, County = "Kalmar", Township = "Mönsterås" },
                new Region() { RegionId = 73, County = "Kalmar", Township = "Emmaboda" },
                new Region() { RegionId = 74, County = "Kalmar", Township = "Kalmar" },
                new Region() { RegionId = 75, County = "Kalmar", Township = "Nybro" },
                new Region() { RegionId = 76, County = "Kalmar", Township = "Oskarshamn" },
                new Region() { RegionId = 77, County = "Kalmar", Township = "Västervik" },
                new Region() { RegionId = 78, County = "Kalmar", Township = "Vimmerby" },
                new Region() { RegionId = 79, County = "Kalmar", Township = "Borgholm" },
                new Region() { RegionId = 80, County = "Gotland", Township = "Gotland" },
                new Region() { RegionId = 81, County = "Blekinge", Township = "Olofström" },
                new Region() { RegionId = 82, County = "Blekinge", Township = "Ronneby" },
                new Region() { RegionId = 83, County = "Blekinge", Township = "Karlshamn" },
                new Region() { RegionId = 84, County = "Blekinge", Township = "Sölvesborg" }




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
                new Residence() { ResidenceId = 1, Address = "Sveavägen 42", BiArea = 20, LandArea = 500, LivingArea = 120, ConstructionYear = 2004, StartingPrice = 2000000, MonthlyFee = 4000, OperatingCost = 50000, PictureListURL = ["https://gotenehus.se/app/uploads/2022/09/puff-vassholm-lada-1344x896.jpg", "https://cdn.decoist.com/wp-content/uploads/2014/08/Indoor-blossoms-in-a-modern-living-room.jpg", "https://i.ytimg.com/vi/w3zIjcnyaJs/maxresdefault.jpg"], RoomCount = 5, CategoryId = 1, RealtorId = 5, RegionId = 1, ResidenceDescription = "Modern lägenhet med öppen planlösning och balkong belägen i centrala stan." },
                new Residence() { ResidenceId = 2, Address = "Storgatan 12", BiArea = 30, LandArea = 0, LivingArea = 100, ConstructionYear = 2000, StartingPrice = 1250000, MonthlyFee = 6500, OperatingCost = 24500, PictureListURL = ["https://www.brahus.se/upload/house/1031629571.jpg"], RoomCount = 3, CategoryId = 2, RealtorId = 4, RegionId = 2, ResidenceDescription = "Charmigt radhus med trädgård och garage i lugnt bostadsområde nära naturen." },
                new Residence() { ResidenceId = 3, Address = "Strandvägen 7", BiArea = 0, LandArea = 1000, LivingArea = 250, ConstructionYear = 2018, StartingPrice = 3000000, MonthlyFee = 4250, OperatingCost = 32400, PictureListURL = ["https://hjaltevadshus.se/app/uploads/2022/10/nyckelfardiga-vitsippan.jpg"], RoomCount = 6, CategoryId = 3, RealtorId = 3, RegionId = 3, ResidenceDescription = "Funkisvilla med pool och havsutsikt på exklusiv adress vid kusten." },
                new Residence() { ResidenceId = 4, Address = "Norra Vallgatan 14", BiArea = 15, LandArea = 625, LivingArea = 130, ConstructionYear = 2009, StartingPrice = 2230000, MonthlyFee = 7000, OperatingCost = 31500, PictureListURL = ["https://www.osloguiden.se/wp-content/uploads/2015/04/Pilestredet.jpg"], RoomCount = 4, CategoryId = 4, RealtorId = 3, RegionId = 2, ResidenceDescription = "Gammal gård renoverad till lyxigt boende med generösa sällskapsytor och stor trädgård." },
                new Residence() { ResidenceId = 5, Address = "Östra Hamngatan 3", BiArea = 50, LandArea = 200, LivingArea = 120, ConstructionYear = 1972, StartingPrice = 1400000, MonthlyFee = 3750, OperatingCost = 20500, PictureListURL = ["https://www.ekonomifokus.se/wp-content/uploads/2019/01/Vad-ingar-vid-kop-och-salj-av-fastighet-och-hus-e1547480095379.jpg"], RoomCount = 5, CategoryId = 5, RealtorId = 1, RegionId = 5, ResidenceDescription = "Lägenhet i nybyggd bostadsrättsförening med gemensam takterrass och närhet till shopping och kommunikationer." }


                );

        }

    }
}
