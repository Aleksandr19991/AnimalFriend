using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFriend.Core.DTOs
{
    public class DonationsDto
    {
        public int Id { get; set; }

        public int Sum { get; set; }

        public DateTime Date {  get; set; }

        public ShelterDto Shelter { get; set; }

        public UserDto User { get; set; }
    }
}
