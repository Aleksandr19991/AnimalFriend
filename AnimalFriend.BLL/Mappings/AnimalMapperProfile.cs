
using AnimalFriend.Core.DTOs;
using AnimalFriend.Core.InputModel;
using AnimalFriend.Core.OutputModels;
using AutoMapper;

namespace AnimalFriend.BLL.Mappings
{
    public class AnimalMapperProfile : Profile
    {
        public AnimalMapperProfile()
        {
            CreateMap<AnimalInputModel, AnimalDto>();
            CreateMap<AnimalDto, AnimalOutputModel>();
        }
    }
}
