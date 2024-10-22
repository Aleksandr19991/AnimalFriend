

namespace AnimalFriend.Core.DTOs
{
    public class FundraisingDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Amount { get; set; }

        public ShelterDto Shelter { get; set; }

        public bool? IsDeleted { get; set; } 
    }
}
