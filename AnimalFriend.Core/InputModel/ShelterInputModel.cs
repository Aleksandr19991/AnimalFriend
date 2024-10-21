
namespace AnimalFriend.Core.InputModel
{
    public class ShelterInputModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
