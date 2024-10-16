using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFriend.Core.DTOs
{
    public class UserShelterDto
    {
        public int Id { get; set; }
        public UserDto User { get; set; }
        public ShelterDto Shelter { get; set; }
    }
}
