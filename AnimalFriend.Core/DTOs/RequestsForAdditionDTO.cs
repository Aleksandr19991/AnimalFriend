using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFriend.Core.DTOs
{
    public class RequestsForAdditionDto
    {
        public int Id { get; set; }

        public UserDto User { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        public string IsActive { get; set; }

        public string IsYes { get; set; }
    }
}
