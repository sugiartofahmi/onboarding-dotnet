using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using onboarding_backend.Common.Responses;
using onboarding_backend.Dtos.Schedule;
using onboarding_backend.Interfaces;
using onboarding_backend.Modules.Schedule.Services;

namespace onboarding_backend.Modules.Schedule.Controllers
{
    [Route("api/schedules")]
    [ApiController]
    public class ScheduleController(ScheduleService scheduleService) : ControllerBase
    {
        private readonly ScheduleService _scheduleService = scheduleService;

        [HttpGet]
        public async Task<ActionResult<ApiResponse>> Index()
        {
            var result = await _scheduleService.Pagination();
            return new ApiResponse(data: result, success: true, message: "Success");

        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse>> Create([FromBody] ScheduleCreateDto request)
        {
            await _scheduleService.Create(request);
            var response = new ApiResponse(success: true, message: "Success");

            return Ok(response);

        }
        [HttpGet("id")]
        public async Task<ActionResult<ApiResponse>> Detail(int id)
        {
            var result = await _scheduleService.FindOne(id);
            return new ApiResponse(data: result, success: true, message: "Success");
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