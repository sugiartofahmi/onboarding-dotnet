using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using onboarding_backend.Common.Validators;

namespace onboarding_backend.Dtos.Auth
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Email tidak boleh kosong")]
        [EmailAddress(ErrorMessage = "Email tidak valid")]
        public string Email { get; set; } = default!;

        [Required(ErrorMessage = "Password tidak boleh kosong")]
        [Password]
        public string Password { get; set; } = default!;
    }
}