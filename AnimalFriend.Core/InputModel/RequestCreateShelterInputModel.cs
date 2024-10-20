

using System.ComponentModel.DataAnnotations;

namespace AnimalFriend.Core.InputModel
{
    public class RequestCreateShelterInputModel
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        [Required(ErrorMessage = "enter NAME")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "min char 2")]
        public string Name { get; set; }

        [Required(ErrorMessage = "select Type")]
        public int Type { get; set; }

        [Required(ErrorMessage = "enter Phone")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "min char 9")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "enter Email")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "min char 6")]
        public string Email { get; set; }

        [Required(ErrorMessage = "enter Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "enter Description")]
        public string Description { get; set; }

        public bool IsActive { get; set; } = true;

        public bool IsYes { get; set; } = true;

        public DateTime DateTimeRegister { get; set; } = DateTime.Now;
    }
}
