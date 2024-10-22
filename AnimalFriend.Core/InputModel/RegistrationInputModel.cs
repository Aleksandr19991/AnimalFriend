using System.ComponentModel.DataAnnotations;


namespace AnimalFriend.Core.InputModel
{
    public class RegistrationInputModel
    {
        [Required( ErrorMessage = "enter NAME")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "min char 2")]
        public string Name { get; set; }

        [Required(ErrorMessage = "enter Email")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "min char 6")]
        [RegularExpression(@"^\S*$", ErrorMessage = "without space")]

        public string Email { get; set; }
        [Required(ErrorMessage = "enter Password")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "min char 6")]
        [RegularExpression(@"^\S*$", ErrorMessage = "without space")]

        public string Phone { get; set; }

        public string Password { get; set; }
    }
}
