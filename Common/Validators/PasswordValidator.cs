using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace onboarding_backend.Common.Validators
{
    public class Password : ValidationAttribute
    {
        private const int MinimumLength = 8;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var password = value as string;

            if (string.IsNullOrEmpty(password))
            {
                return new ValidationResult("Password harus diisi");
            }

            if (password.Length < MinimumLength)
            {
                return new ValidationResult($"Password harus lebih dari {MinimumLength} karakter");
            }

            if (!password.Any(char.IsUpper))
            {
                return new ValidationResult("Password harus mengandung setidaknya satu huruf kapital");
            }

            if (!Regex.IsMatch(password, @"[\W_]"))
            {
                return new ValidationResult("Password harus mengandung setidaknya satu karakter alfanumerik");
            }

            return ValidationResult.Success;
        }

    }
}