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
            CreateMap<RequestToAddShelterDto, RequestAddShelterOutputModel>();
        }
    }
}
