using System.ComponentModel.DataAnnotations;

namespace AnimalFriend.Core.InputModel
{
    public class AnimalInputModel
    {
        [Required(ErrorMessage = "enter NAME")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "min char 2")]
        public string Name { get; set; }

        public int? Age { get; set; }

        public string? Description { get; set; }

        public string? ImagePath { get; set; }

        public int TypeId { get; set; }

        public bool? IsDeleted { get; set; } = false;
    }
}


