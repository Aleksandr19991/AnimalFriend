using AnimalFriend.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFriend.Core.DTOs
{
    public class FundraisingDto
    {
        public int Id { get; set; }

        public ShelterDto Shelter {  get; set; }

        public string Description { get; set; }
    }
}
