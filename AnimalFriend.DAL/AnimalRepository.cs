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

        //context.Database.EnsureCreated();

        public void AddAnimal(AnimalDto animal)
        {
            context.Animals.Add(animal);
            context.SaveChanges();
        }

        public AnimalDto GetAnimalById(int Animalid) 
        {
            var animal = context.Animals.Where(a => a.Id == Animalid).FirstOrDefault();

            return animal;
        }
    }
}
