using AutoMapper;

namespace IdentityServerApi_AspNetIdentity.AutoMapperConfig
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<ApplicationUser, ApplicationUserDto>().ReverseMap();

            //CreateMap<ApplicationUser2, ApplicationUserDto>().ReverseMap();

            //CreateMap<ApplicationUser, ApplicationUserDto>()
            //    .ForMember(d => d.Company, m => new Company()).ReverseMap();

            // .ForMember(d => d.Company, m => m.MapFrom(src => src.Company)).ReverseMap();
        }
    }
}