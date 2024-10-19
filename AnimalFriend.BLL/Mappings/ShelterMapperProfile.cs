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
            CreateMap<ShelterInputModel, ShelterDto>();
            CreateMap<ShelterDto, ShelterCardOutputModel>();
        }
    }
}
