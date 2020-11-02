using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloMVCWorld.CustomValidations
{
    public class BirthdayValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
                return new ValidationResult("No birthday was entered.");
            DateTime birthday = (DateTime)value;
            if (birthday.Year < 1990)
                return new ValidationResult("Surely you are not that old?");
            if (birthday.Year > 2003)
                return new ValidationResult("Sorry, you're too young for this webiste!");
            if (birthday.Month == 12)
                return new ValidationResult("Sorry, we don't accept anyone born in December!");
            return ValidationResult.Success;
        }
    }
}
