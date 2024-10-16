using AnimalFriend.Core.DTOs;

namespace AnimalFriend.Core.OutputModels
{
    public class AnimalOutputModel
    {
        //public int Id { get; set; }

        //public string Name { get; set; }

        //public string ImagePath { get; set; }

        //public string AnimalSpecies { get; set; }

        //public string Age { get; set; }

        //public string Description { get; set; }

        //public string NameShelter { get; set; }

        //public long CallShelter { get; set; }

        public int Id { get; set; }

        public string? Name { get; set; }

        public int? Age { get; set; }

        public string? Description { get; set; }

        public string? ImagePath { get; set; }

        public bool? IsDeleted { get; set; }
    }
}
