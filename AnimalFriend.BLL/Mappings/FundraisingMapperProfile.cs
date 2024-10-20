using AnimalFriend.Core.DTOs;
using AnimalFriend.Core.InputModel;
using AnimalFriend.Core.OutputModels;
using AutoMapper;

namespace AnimalFriend.BLL.Mappings
{
    public class FundraisingMapperProfile : Profile
    {
        public FundraisingMapperProfile()
        {
            CreateMap<FundraisingInputModel, FundraisingDto>();
            CreateMap<FundraisingDto, FundraisingOutputModel>();
        }
    }
}
