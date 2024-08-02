using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using onboarding_backend.Database;

namespace onboarding_backend.Modules.Schedule.Repositories
{
    public class ScheduleRepository(AppDbContext context)
    {
        private readonly AppDbContext _context = context;
        public async Task Pagination()
        {

        }

        public async Task FindOne(int id)
        {

        }

        public async Task Create()
        { }

        public async Task Update()
        { }

        public async Task Delete(int id)
        { }

    }
}