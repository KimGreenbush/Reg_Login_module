using System;
using System.ComponentModel.DataAnnotations;

namespace RegLoginModule.Models
{
    public class LoginUser
    {

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string UserEmail { get; set; }

        [Required]
        [MinLength(8)]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]

        public string UserPassword { get; set; }
    }
}