using AnimalFriend.Core.DTOs;

namespace AnimalFriend.Core.OutputModels
{
    public class AnimalOutputModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImagePath { get; set; }

        public string AnimalSpecies { get; set; }

        public string Age { get; set; }

        public string Description { get; set; }

        public string NameShelter { get; set; }

        public long CallShelter { get; set; }

        // Жду готовой БД и меняю модель
        
        //public int Id { get; set; }

        //public string Name { get; set; }

        //public string Age { get; set; }

        //public string Description { get; set; }

        //public string ImagePath { get; set; }

        //public AnimalTypeDTO Type { get; set; }

        //public string ShelterId { get; set; }

        //public bool IsDeleted { get; set; }
    }
}
