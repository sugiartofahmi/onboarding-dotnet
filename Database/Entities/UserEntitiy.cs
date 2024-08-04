using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using onboarding_backend.Interfaces;

namespace onboarding_backend.Database.Entities
{
    public class User : Base, IUser
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Avatar { get; set; }

        public bool IsAdmin { get; set; } = false;
        public List<Order>? Orders { get; set; }


    }
}