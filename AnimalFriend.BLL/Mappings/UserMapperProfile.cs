using AnimalFriend.Core.DTOs;
using AnimalFriend.Core.InputModel;
using AutoMapper;

namespace AnimalFriend.BLL.Mappings
{
    public class UserMapperProfile : Profile
    {
        public UserMapperProfile()
        {
            CreateMap<RegistrationInputModel, UserDto>();//ReverseMap() => с этим сможет работать в обратную сторону но formember не работает тогда
           
            //.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));  // if name != name
        }
    }
}
