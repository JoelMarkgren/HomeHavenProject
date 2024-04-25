using AutoMapper;
using HomeHavenAPI.Models;

namespace HomeHavenAPI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Residence, ResidenceDto>()
                .ForMember(s => s.MainPicture, o => o.MapFrom(r => r.PictureListURL[0]))
                .ReverseMap();
        }
    }
}
