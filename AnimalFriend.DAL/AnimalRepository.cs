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

        private Context db;

        public AnimalRepository()
        {
            this.db = context;
        }

        public int AddAnimal(AnimalDto animal)
        {
            db.Animals.Add(animal);

            return 0;
        }

        public AnimalDto GetAnimalById(int Animalid) 
        {
            var animal = context.Animals.Where(a => a.Id == Animalid).FirstOrDefault();

            return animal;
        }
    }
}
