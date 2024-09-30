using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFriend.Core.OutputModels
{
    public class ShelterCardOutputModel
    {
        public int Id { get; set; }

        public string ImagePath { get; set; }
  
        public string NameShelter { get; set; }

        public string TypeAnimal { get; set; }

        public string Description { get; set; }
    }
}
