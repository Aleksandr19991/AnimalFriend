

namespace AnimalFriend.Core.InputModel
{
    public class ApplicationCreateShelterInputModel
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string? Description { get; set; }

        public bool IsActive { get; set; } = true;

        public bool IsYes { get; set; } = true;

        public DateTime DateTimeRegister { get; set; } = DateTime.Now;
    }
}
