using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFriend.Core.DTOs
{
    public class ReviewDto
    {
        public int Id { get; set; }

        public string? Text { get; set; }

        public int UserId { get; set; }

        public int ShelterId { get; set; }

        public int? Stars { get; set; }

        public DateOnly? Data {  get; set; }
    }
}
