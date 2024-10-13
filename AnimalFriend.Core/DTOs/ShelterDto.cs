﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFriend.Core.DTOs
{
    public class ShelterDto
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public string Description { get; set; }

        public string Adress { get; set; }

        public string Phone {  get; set; }

        public bool? IsDeleted { get; set; }

        public List<UserDto> User { get; set; }

        public AnimalTypeDto Type { get; set; }

    }
}
