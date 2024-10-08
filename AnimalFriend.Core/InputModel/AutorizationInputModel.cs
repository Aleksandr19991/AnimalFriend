﻿
using System.ComponentModel.DataAnnotations;

namespace AnimalFriend.Core.InputModel
{
    public class AutorizationInputModel
    {
        [Required(ErrorMessage = "enter NAME")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "min char 6")]
        public string Email { get; set; }

        [Required(ErrorMessage = "enter PASSWORD")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "min char 5")]
        public string Password { get; set; }
    }
}
