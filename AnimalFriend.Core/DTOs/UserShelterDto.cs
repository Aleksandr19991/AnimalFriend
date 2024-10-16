

namespace AnimalFriend.Core.DTOs
{
    public class UserShelterDto
    {
        public int Id { get; set; }
        public UserDto User { get; set; }
        public ShelterDto Shelter { get; set; }
    }
}
