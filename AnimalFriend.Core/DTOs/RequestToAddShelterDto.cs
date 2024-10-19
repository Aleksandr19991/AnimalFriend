

namespace AnimalFriend.Core.DTOs
{
    public class RequestToAddShelterDto
    {
        public int Id { get; set; }

        public UserDto? User { get; set; }

        public string Name { get; set; }

        public int Type { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string? Description { get; set; }

        public bool IsActive { get; set; } 

        public bool IsYes { get; set; } 
    }
}
