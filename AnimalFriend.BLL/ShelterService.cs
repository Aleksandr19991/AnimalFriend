using AnimalFriend.Core.OutputModels;
using AnimalFriend.DAL;
using AutoMapper;
using AnimalFriend.BLL.Mappings;
using AnimalFriend.Core.DTOs;

namespace AnimalFriend.BLL
{
    public class ShelterService
    {
        private ShelterRepository ShelterRepository { get; set; }

        private Mapper _mapper;

        public ShelterService()
        {
            ShelterRepository = new();

            var config = new MapperConfiguration(
            cfg =>
            {
                cfg.AddProfile(new ShelterMapperProfile());
            });
            _mapper = new Mapper(config);
        }
        public List<ShelterCardOutputModel> GetAllShelter()
        {
            var shelters = ShelterRepository.GetAllShelter();
            var result = _mapper.Map<List<ShelterCardOutputModel>>(shelters);
            return result;
        }
    }
}
