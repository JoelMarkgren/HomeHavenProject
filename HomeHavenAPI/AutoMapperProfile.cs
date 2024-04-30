using AutoMapper;
using HomeHavenAPI.Dtos;
using HomeHavenAPI.Models;

namespace HomeHavenAPI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Residence, ResidenceDto>()              
                .ReverseMap();

		}
    }
}
