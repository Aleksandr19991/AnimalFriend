using AnimalFriend.Core.DTOs;
using Microsoft.EntityFrameworkCore;

namespace AnimalFriend.DAL
{
    public class AnimalRepository
    {
        Context context = new Context();

        public void AddAnimal(AnimalDto animal)
        {
            context.Animals.Add(animal);
            context.SaveChanges();
        }

        public AnimalDto GetAnimalById(int AnimalId)
        {
            var animalId = context.Animals.Where(a => a.Id == AnimalId).FirstOrDefault();

            return animalId;
        }

        public List<AnimalDto> GetAllAnimals()
        {
            return context.Animals.ToList();
        }

        public List<AnimalDto> GetAllAnimalsByShelterId(int ShelterId)
        {
            var animal = context.Animals.Include(a => a.Shelter).Where(s => s.Shelter.Id == ShelterId).FirstOrDefault();

            return context.Animals.ToList();
        }

        public void UpdateAnimal(AnimalDto animal)
        {
            context.Animals.Update(animal);
            context.SaveChanges();
        }

        public AnimalTypeDto GetTypeAnimalById(int AnimalId)
        {
            var animal = context.Animals.Include(a => a.Type).Where(a => a.Id == AnimalId).FirstOrDefault();

            return animal.Type;
        }

        public void RemoveAnimal(AnimalDto animal)
        {
            context.Animals.Remove(animal);
            context.SaveChanges();
        }
    }
}
