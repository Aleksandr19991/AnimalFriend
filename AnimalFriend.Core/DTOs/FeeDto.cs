using AnimalFriend.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFriend.Core.DTOs
{
    public class FeeDto
    {
        public int Id { get; set; }

        public List<ShelterDto> Shelter {  get; set; }

        public string Description { get; set; }
    }
}
