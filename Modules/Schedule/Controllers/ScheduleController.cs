using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using onboarding_backend.Modules.Schedule.Services;

namespace onboarding_backend.Modules.Schedule.Controllers
{
    [Route("api/schedules")]
    [ApiController]
    public class ScheduleController(ScheduleService scheduleService)
    {
        private readonly ScheduleService _scheduleService = scheduleService;

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            return null;

        }

        [HttpPost]
        public Task<ActionResult> Create()
        {
            return null;
        }
        [HttpGet("id")]
        public Task<ActionResult> Detail(int id)
        {
            return null;
        }
        [HttpDelete("id")]
        public Task<ActionResult> Delete(int id)
        {
            return null;
        }
        [HttpPut("id")]
        public Task<ActionResult> Update(int id)
        {
            return null;
        }
    }
}