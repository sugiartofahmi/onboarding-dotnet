using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using onboarding_backend.Database.Entities;

namespace onboarding_backend.Interfaces
{
    public interface IUser : IBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Avatar { get; set; }

        public List<Order> Orders { get; set; }
    }
}