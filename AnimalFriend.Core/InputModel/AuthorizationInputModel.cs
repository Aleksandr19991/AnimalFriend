using System.ComponentModel.DataAnnotations;

namespace AnimalFriend.Core.InputModel
{
    public class AuthorizationInputModel
    {
        [Required(ErrorMessage = "enter Email")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "min char 6")]
        [RegularExpression(@"^\S*$", ErrorMessage = "without space")]
        public string Email { get; set; }

        [Required(ErrorMessage = "enter PASSWORD")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "min char 5")]
        [RegularExpression(@"^\S*$", ErrorMessage = "without space")]
        public string Password { get; set; }
    }
}
