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

        public AnimalOutputModel GetAnimalById(int AnimalId)
        {
            var AnimalDto = AnimalRepository.GetAnimalById(AnimalId);

            var animal = _mapper.Map<AnimalOutputModel>(AnimalDto);

            return animal;
        }

        public List<AnimalOutputModel> GetAllAnimals()
        {
            var AnimalDtos = AnimalRepository.GetAllAnimals();

            List<AnimalOutputModel> animals = new();

            foreach (var AnimalDto in AnimalDtos)
            {
                AnimalOutputModel animal = _mapper.Map<AnimalOutputModel>(AnimalDto);

                animals.Add(animal);
            }

            return animals;
        }

        public List<AnimalOutputModel> GetAllAnimalsByShelterId(int ShelterId)
        {
            var AnimalDtos = AnimalRepository.GetAllAnimalsByShelterId(ShelterId);

            List<AnimalOutputModel> animals = new();

            foreach (var AnimalDto in AnimalDtos)
            {
                AnimalOutputModel animal = _mapper.Map<AnimalOutputModel>(AnimalDto);

                animals.Add(animal);
            }

            return animals;
        }

        public int UpdateAnimal(AnimalInputModel animal)
        {
            var AnimalDto = _mapper.Map<AnimalDto>(animal);

            var AnimalId = AnimalRepository.UpdateAnimal(AnimalDto);

            return AnimalId;
        }

        public AnimalOutputModel GetTypeAnimalById(int AnimalId)
        {
            var AnimalTypeDto = AnimalRepository.GetTypeAnimalById(AnimalId);

            var animalType = _mapper.Map<AnimalOutputModel>(AnimalTypeDto);

            return animalType;
        }

        public void RemoveAnimal(AnimalDto animal)
        {
            var AnimalDto = _mapper.Map<AnimalDto>(animal);

            AnimalRepository.RemoveAnimal(AnimalDto);
        }
    }
}
