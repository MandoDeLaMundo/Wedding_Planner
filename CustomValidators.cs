using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wedding_Planner
{
    public class CustomValidators
    {
        public class FutureDate : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                if (value == null)
                {
                    return ValidationResult.Success;
                }

                if ((DateTime)value < DateTime.Now)
                {
                    return new ValidationResult("Date must be in the future.");
                }
                return ValidationResult.Success;
            }
        }
    }
}