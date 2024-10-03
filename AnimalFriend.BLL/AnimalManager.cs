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
                    Age="4 года",
                    Description="Гав",
                    NameShelter="Приют1",
                    CallShelter=+70000000000
                },
                new AnimalOutputModel()
                {
                    Id=2,
                    Name="Барсик",
                    AnimalSpecies="Котэ",
                    Age="3 года",
                    Description="Мяу",
                    NameShelter="Приют2",
                    CallShelter=+70000000000
                },
                new AnimalOutputModel()
                {
                    Id=3,
                    Name="Беляш",
                    AnimalSpecies="Собакен",
                    Age="5 лет",
                    Description="Гав",
                    NameShelter="Приют1",
                    CallShelter=+70000000000
                },

                new AnimalOutputModel()
                {
                    Id=4,
                    Name="Мурка",
                    AnimalSpecies="Котэ",
                    Age="7 лет",
                    Description="Мяу",
                    NameShelter="Приют2",
                    CallShelter=+70000000000
                },
                
                new AnimalOutputModel()
                {
                    Id=5,
                    Name="Вольт",
                    AnimalSpecies="Собакен",
                    Age="10 лет",
                    Description="Гав",
                    NameShelter="Приют1",
                    CallShelter=+70000000000
                },
            };
        }

        public AnimalOutputModel GeAnimalById(int id)
        {
            if (id == 1)
            {
                return new AnimalOutputModel()
                {
                    Id = id,
                    Name = "Мухтар",
                    AnimalSpecies = "Собакен",
                    Age = "4 года",
                    Description = "Гав",
                    NameShelter = "Приют1",
                    CallShelter = +70000000000
                };
            }
            else if (id == 2)
            {
                return new AnimalOutputModel()
                {
                    Id = id,
                    Name = "Барсик",
                    AnimalSpecies = "Котэ",
                    Age = "3 года",
                    Description = "Мяу",
                    NameShelter = "Приют2",
                    CallShelter = +70000000000
                };
            }
            else if (id == 3)
            {
                return new AnimalOutputModel()
                {
                    Id = id,
                    Name = "Беляш",
                    AnimalSpecies = "Собакен",
                    Age = "5 лет",
                    Description = "Гав",
                    NameShelter = "Приют1",
                    CallShelter = +70000000000
                };
            }
            else if (id == 4)
            {
                return new AnimalOutputModel()
                {
                    Id = id,
                    Name = "Мурка",
                    AnimalSpecies = "Котэ",
                    Age = "7 лет",
                    Description = "Мяу",
                    NameShelter = "Приют2",
                    CallShelter = +70000000000
                };
            }
            else if (id == 5)
            {
                return new AnimalOutputModel()
                {
                    Id = id,
                    Name = "Вольт",
                    AnimalSpecies = "Собакен",
                    Age = "10 лет",
                    Description = "Гав",
                    NameShelter = "Приют1",
                    CallShelter = +70000000000
                };
            }
            else { return new AnimalOutputModel(); }
        }
    }
}
