

namespace AnimalFriend.Core.DTOs
{
    public class AnimalDto
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int? Age { get; set; }

        public string? Description { get; set; }

        public string? ImagePath { get; set; }

        public AnimalTypeDto Type { get; set; }

        public ShelterDto Shelter { get; set; }

        public bool? IsDeleted { get; set; }
    }
}
