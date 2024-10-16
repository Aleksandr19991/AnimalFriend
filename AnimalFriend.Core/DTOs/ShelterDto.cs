

namespace AnimalFriend.Core.DTOs
{
    public class ShelterDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public bool IsDeleted { get; set; }

        public AnimalTypeDto Type { get; set; }
    }
}
