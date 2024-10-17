using AnimalFriend.Core.DTOs;
using AnimalFriend.Core.InputModel;
using AnimalFriend.Core.OutputModels;
using AutoMapper;

namespace AnimalFriend.BLL.Mappings
{
    public class UserMapperProfile : Profile
    {
        public UserMapperProfile()
        {
            CreateMap<RegistrationInputModel, UserDto>()
                .ForMember(dest => dest.Role.Id, opt => opt.MapFrom(src => src.RoleId));
            CreateMap<UserDto, AuthorizationOutputModel>()
            .ForMember(dest => dest.RoleId, opt => opt.MapFrom(src => src.Role));
            //.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));  // if name != name
            //ReverseMap() => с этим сможет работать в обратную сторону но formember не работает тогда
        }
    }
}
