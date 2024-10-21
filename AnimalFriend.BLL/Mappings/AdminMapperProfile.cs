using AnimalFriend.Core.DTOs;
using AnimalFriend.Core.InputModel;
using AnimalFriend.Core.OutputModels;
using AutoMapper;


namespace AnimalFriend.BLL.Mappings
{
    public class AdminMapperProfile: Profile
    {
        public AdminMapperProfile()
        {
            CreateMap<RequestToAddShelterDto, RequestAddShelterOutputModel>().
                ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.User.Id));
            CreateMap<RequestAddShelterOutputModel, ShelterDto>().
                ForMember(dest => dest.Type, src => src.Ignore());
            //BeforeMap((src, dest) => dest.Type = new()).
        }
    }
}