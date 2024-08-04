using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using onboarding_backend.Database;

namespace onboarding_backend.Modules.Auth.Repositories
{
    public class AuthRepository(AppDbContext context)
    {
        public AppDbContext _context = context;


    }
}