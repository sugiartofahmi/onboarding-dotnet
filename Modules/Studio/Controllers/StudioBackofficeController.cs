using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using onboarding_backend.Common.Responses;
using onboarding_backend.Dtos.Common;
using onboarding_backend.Dtos.Studio;
using onboarding_backend.Interfaces;
using onboarding_backend.Modules.Studio.Services;

namespace onboarding_backend.Modules.Studio.Controllers
{
    [Route("api/backoffice/studios")]
    [ApiController]
    [Authorize]
    public class StudioBackofficeController(StudioService studioService) : ControllerBase
    {
        private readonly StudioService _studioService = studioService;

        [HttpGet]
        public async Task<ActionResult<ApiResponse>> Index([FromBody] IndexDto request)
        {
            var result = await _studioService.Pagination(request);
            return new ApiResponse(data: result, success: true, message: "Success");

        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] StudioCreateDto request)
        {
            await _studioService.Create(request);
            var response = new ApiResponse(success: true, message: "Success");

            return Ok(response);

        }
        [HttpGet("id")]
        public async Task<ActionResult<ApiResponse>> Detail(int id)
        {
            var result = await _studioService.FindOne(id);
            return new ApiResponse(data: result, success: true, message: "Success");

        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _studioService.Delete(id);
            if (!result) return NotFound();
            var response = new ApiResponse(success: true, message: "Success");

            return Ok(response);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] StudioUpdateDto request)
        {
            var result = await _studioService.Update(id, request);
            if (!result) return BadRequest();
            var response = new ApiResponse(success: true, message: "Success");

            return Ok(response);
        }
    }
}