using AnimalFriend.Core.DTOs;
using AnimalFriend.Core.InputModel;
using AnimalFriend.Core.OutputModels;
using AutoMapper;

namespace AnimalFriend.BLL.Mappings
{
    public class ShelterMapperProfile: Profile
    {
        public ShelterMapperProfile() 
        {
            CreateMap<ShelterDto, ShelterCardOutputModel>().
                ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type.Type));
        }
    }
}
