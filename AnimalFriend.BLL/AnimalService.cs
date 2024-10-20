using AnimalFriend.BLL.Mappings;
using AnimalFriend.Core.DTOs;
using AnimalFriend.Core.InputModel;
using AnimalFriend.Core.OutputModels;
using AnimalFriend.DAL;
using AutoMapper;


namespace AnimalFriend.BLL
{
    public class AnimalService
    {
        private AnimalRepository AnimalRepository { get; set; }

        private Mapper _mapper;

        public AnimalService()
        {
            AnimalRepository = new AnimalRepository();

            var config = new MapperConfiguration(
            cfg =>
            {
                cfg.AddProfile(new AnimalMapperProfile());
            });
            _mapper = new Mapper(config);
        }

        public void AddAnimal(AnimalInputModel animal)
        {
            var animalDto = _mapper.Map<AnimalDto>(animal);

            AnimalRepository.AddAnimal(animalDto); 
        }

        public AnimalOutputModel GetAnimalById(int AnimalId)
        {
            var animalDto = AnimalRepository.GetAnimalById(AnimalId);

            var animal = _mapper.Map<AnimalOutputModel>(animalDto);

            return animal;
        }

        public List<AnimalOutputModel> GetAllAnimals()
        {
            var animalDtos = AnimalRepository.GetAllAnimals();

            List<AnimalOutputModel> animals = new();

            foreach (var animalDto in animalDtos)
            {
                AnimalOutputModel animal = _mapper.Map<AnimalOutputModel>(animalDto);

                animals.Add(animal);
            }

            return animals;
        }

        public List<AnimalOutputModel> GetAllAnimalsByShelterId(int shelterId)
        {
            var animalDtos = AnimalRepository.GetAllAnimalsByShelterId(shelterId);

            List<AnimalOutputModel> animals = new();

            foreach (var animalDto in animalDtos)
            {
                AnimalOutputModel animal = _mapper.Map<AnimalOutputModel>(animalDto);

                animals.Add(animal);
            }

            return animals;
        }

        public void UpdateAnimal(AnimalInputModel animal)
        {
            var animalDto = _mapper.Map<AnimalDto>(animal);

            AnimalRepository.UpdateAnimal(animalDto);
        }

        public AnimalOutputModel GetTypeAnimalById(int animalId)
        {
            var animalTypeDto = AnimalRepository.GetTypeAnimalById(animalId);

            var animalType = _mapper.Map<AnimalOutputModel>(animalTypeDto);

            return animalType;
        }
    }
}
