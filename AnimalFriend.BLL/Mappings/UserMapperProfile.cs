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
            CreateMap<RegistrationInputModel, UserDto>();
            CreateMap<UserDto, AuthorizationOutputModel>()
                .ForMember(dest => dest.RoleId, opt => opt.MapFrom(src => src.Role.Id));
            CreateMap<UserRoleDto, UserRoleModel>();
            CreateMap<UserRoleModel, UserRoleDto>();
            //.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));  // if name != name
            //ReverseMap() => с этим сможет работать в обратную сторону но formember не работает тогда
        }
    }
}
