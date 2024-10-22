﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFriend.Core.OutputModels
{
    public class ShelterCardOutputModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public string PhotoPath { get; set; }
    }
}
