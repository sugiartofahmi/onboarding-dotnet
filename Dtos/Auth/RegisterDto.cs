using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace onboarding_backend.Dtos.Auth
{
    public class RegisterDto : LoginDto
    {

        [Required(ErrorMessage = "Avatar tidak boleh kosong")]
        public string Avatar { get; set; }

        [Required(ErrorMessage = "Nama tidak boleh kosong")]
        public string Name { get; set; }
    }
}