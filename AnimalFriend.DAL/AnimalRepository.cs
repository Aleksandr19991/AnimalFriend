using AnimalFriend.Core.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFriend.DAL
{
    public class AnimalRepository
    {
        Context context = new Context();

        public int AddAnimal(AnimalDto animal)
        {
            context.Animals.Add(animal);
            context.SaveChanges();
            
            return animal.Id;
        }

        public AnimalDto GetAnimalById(int AnimalId)
        {
            var animal = context.Animals.Where(a => a.Id == AnimalId).FirstOrDefault();

            return animal;
        }

        public List<AnimalDto> GetAllAnimals() 
        {  
            return context.Animals.ToList(); 
        }

        //public List<AnimalDto> GetAllAnimalsByShelterId(int ShelterId) 
        //{
        //    var animal = context.Animals.Include(a => a.Shelter).Where(s => s.Id == ShelterId).FirstOrDefault();

        //    return context.Animals.ToList();
        //}

        //public int UpdateAnimal(AnimalDto animal)
        //{
        //    context.Animals.Update(animal);
        //    context.SaveChanges();
        //    return animal.Id;
        //}

        //public AnimalTypeDto GetTypeAnimalById(int AnimalId)
        //{
        //    var animal = context.Animals.Where(a => a.Id == AnimalId).FirstOrDefault();

        //    return animal.Type;
        //}

        public void RemoveAnimal(AnimalDto animal)
        {
            context.Animals.Remove(animal);
            context.SaveChanges();
        }
    }
}
