using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace onboarding_backend.Dtos.Auth
{
    public class RegisterDto : LoginDto
    {

        public string Avatar { get; set; }

        [Required]
        public string Name { get; set; }
    }
}