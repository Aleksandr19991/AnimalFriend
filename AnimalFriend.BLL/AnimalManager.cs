using AnimalFriend.Core.OutputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFriend.BLL
{
    public class AnimalManager
    {
        public List<AnimalOutputModel> GetAllAnimals()
        {
            //return new List<AnimalOutputModel>();
            return new List<AnimalOutputModel>
            {
                new AnimalOutputModel()
                {
                    Id=1,
                    Name="Мухтар",
                    AnimalSpecies="Собакен",
                    Age=1,
                    Description="Гав"
                },
                new AnimalOutputModel()
                {
                    Id=2,
                    Name="Барсик",
                    AnimalSpecies="Котэ",
                    Age=1,
                    Description="Мяу"
                },
                new AnimalOutputModel()
                {
                    Id=3,
                    Name="Беляш",
                    AnimalSpecies="Собакен",
                    Age=4,
                    Description="Гав"
                },

                new AnimalOutputModel()
                {
                    Id=4,
                    Name="Мурка",
                    AnimalSpecies="Котэ",
                    Age=8,
                    Description="Мяу"
                },
                
                new AnimalOutputModel()
                {
                    Id=5,
                    Name="Вольт",
                    AnimalSpecies="Собакен",
                    Age=10,
                    Description="Гав"
                },
            };
        }

        public AnimalOutputModel GeAnimalById(int id)
        {
            if (id % 2 == 0)
            {
                return new AnimalOutputModel()
                {
                    Id = id,
                    Name = "Мурка",
                    AnimalSpecies = "Котэ",
                    Age = 8,
                    Description = "Мяу"
                };
            }
            else
            {
                return new AnimalOutputModel()
                {
                    Id = 5,
                    Name = "Вольт",
                    AnimalSpecies = "Собакен",
                    Age = 10,
                    Description = "Гав"
                };
            }
        }
    }
}
