using AnimalFriend.BLL.Mappings;
using AnimalFriend.Core.DTOs;
using AnimalFriend.Core.InputModel;
using AnimalFriend.Core.OutputModels;
using AnimalFriend.DAL;
using AutoMapper;


namespace AnimalFriend.BLL
{
    public class AnimalManager
    {
        private AnimalRepository AnimalRepository { get; set; }

        private Mapper _mapper;

        public AnimalManager() 
        {
            AnimalRepository = new AnimalRepository();

            var config = new MapperConfiguration(
            cfg =>
            {
                cfg.AddProfile(new AnimalMapperProfile());
            });
            _mapper = new Mapper(config);
        }

        public int AddAnimal(AnimalInputModel animal)
        {
            var AnimalDto = _mapper.Map<AnimalDto>(animal);

            var AnimalId = AnimalRepository.AddAnimal(AnimalDto);

            return AnimalId;
        }
    }
}
