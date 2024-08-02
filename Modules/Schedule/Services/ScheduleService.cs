using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using onboarding_backend.Modules.Schedule.Repositories;

namespace onboarding_backend.Modules.Schedule.Services
{
    public class ScheduleService(ScheduleRepository scheduleRepository)
    {
        private readonly ScheduleRepository _scheduleRepository = scheduleRepository;
    }
}