using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFriend.Core.DTOs
{
    public class UserDTO
    {
        public int? Id { get; set; }

        public string? Name { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public int? RoleId { get; set; }

        public string? RoleDescription { get; set; }

        public string? Password { get; set; }

        public bool? IsDeleted { get; set; }

        public List<AnimalDTO>? Animal { get; set; }

        public List<ShelterDTO>? Shelter { get; set; }
    }
}
