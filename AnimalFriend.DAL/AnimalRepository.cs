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

        public void AddAnimal(AnimalDto animal)
        {
            context.Animals.Add(animal);
            context.SaveChanges();
        }

        public AnimalTypeDto GetTypeAnimalById(int Animalid)
        {
            var animal = context.Animals.Where(a => a.Id == Animalid).FirstOrDefault();

            return animal.Type;
        }

        public AnimalDto GetAnimalById(int Animalid) 
        {
            var animal = context.Animals.Where(a => a.Id == Animalid).FirstOrDefault();

            return animal;
        }

        public int UpdateAnimal(AnimalDto animal)
        {
            foreach (var item in context.Animals) 
            {
                item.Id = animal.Id;
                item.Name = animal.Name;
                item.Age = animal.Age;
                item.Description = animal.Description;
                item.ImagePath = animal.ImagePath;
                item.Type = animal.Type;
            }
            
            context.SaveChanges();

            return 0;
            //найти решение
        }
    }
}
