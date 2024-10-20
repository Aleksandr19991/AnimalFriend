using AnimalFriend.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFriend.Core.OutputModels
{
    public class RequestAddShelterOutputModel
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Name { get; set; }

        public int Type { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string? Description { get; set; }

        public bool IsActive { get; set; }

        public bool IsYes { get; set; }

        public string DateTime { get; set; }
    }
}
