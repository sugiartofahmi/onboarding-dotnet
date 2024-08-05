using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using onboarding_backend.Common.Responses;
using onboarding_backend.Dtos.Common;
using onboarding_backend.Dtos.Schedule;
using onboarding_backend.Interfaces;
using onboarding_backend.Modules.Schedule.Services;

namespace onboarding_backend.Modules.Schedule.Controllers
{
    [Route("api/backoffice/schedules")]
    [ApiController]
    // [Authorize]
    public class ScheduleBackofficeController(ScheduleService scheduleService) : ControllerBase
    {
        private readonly ScheduleService _scheduleService = scheduleService;

        [HttpPost]
        public async Task<ActionResult<ApiResponse>> Create([FromBody] ScheduleCreateDto request)
        {
            await _scheduleService.Create(request);
            var response = new ApiResponse(success: true, message: "Success");

            return Ok(response);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _scheduleService.Delete(id);
            if (!result) return NotFound();
            var response = new ApiResponse(success: true, message: "Success");

            return Ok(response);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] ScheduleUpdateDto request)
        {
            var result = await _scheduleService.Update(id, request);
            if (!result) return BadRequest();
            var response = new ApiResponse(success: true, message: "Success");

            return Ok(response);
        }
    }
}