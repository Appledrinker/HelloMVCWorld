using HelloMVCWorld.CustomValidations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloMVCWorld.Models
{
    public class WebUser
    {
        [Required(ErrorMessage = "You must enter a value for the First Name field.")]
        [StringLength(25, ErrorMessage = "The First Name must be no longer than 25 characters!")]
        public string FirstName { get; set; }

        [Required (ErrorMessage = "You must enter a value for the Last Name field.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The Last Name must be between 3 and 50 characters long.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "You must enter a value for the Email field.")]
        [EmailAddress(ErrorMessage = "Please ener a valid e-mail address.")]
        public string MailAddress { get; set; }

        [Required(ErrorMessage = "You must enter a value for the Birthday field!")]
        [BirthdayValidation] // will still check this even if the field doesn't exist for Required before showing the Required error message
        public DateTime? Birthday { get; set; }
    }
}
