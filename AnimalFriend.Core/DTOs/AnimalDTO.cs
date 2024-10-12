using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFriend.Core.DTOs
{
    public class AnimalDTO
    {
        public int? Id { get; set; }

        public string? Name { get; set; }

        public string? Age { get; set; }

        public string? Description { get; set; }

        public string? ImagePath { get; set; }

        public AnimalTypeDTO Type {  get; set; }

        public string? ShelterId { get; set; }

        public bool? IsDeleted { get; set; }
    }
}
