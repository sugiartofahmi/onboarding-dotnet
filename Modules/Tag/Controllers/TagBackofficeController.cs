using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using onboarding_backend.Common.Responses;
using onboarding_backend.Dtos.Common;
using onboarding_backend.Dtos.Tag;
using onboarding_backend.Interfaces;
using onboarding_backend.Modules.Tag.Services;

namespace onboarding_backend.Modules.Tag.Controllers
{
    [Route("api/backoffice/tags")]
    [ApiController]
    [Authorize]
    public class TagBackofficeController(TagService tagService) : ControllerBase
    {
        private readonly TagService _tagService = tagService;

        [HttpGet]
        public async Task<ActionResult<ApiResponse>> Index([FromBody] IndexDto request)
        {
            var result = await _tagService.Pagination(request);
            return new ApiResponse(data: result, success: true, message: "Success");

        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] TagCreateDto request)
        {
            await _tagService.Create(request);
            var response = new ApiResponse(success: true, message: "Success");

            return Ok(response);

        }
        [HttpGet("id")]
        public async Task<ActionResult<ApiResponse>> Detail(int id)
        {
            var result = await _tagService.FindOne(id);
            return new ApiResponse(data: result, success: true, message: "Success");

        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _tagService.Delete(id);
            if (!result) return NotFound();
            var response = new ApiResponse(success: true, message: "Success");

            return Ok(response);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] TagUpdateDto request)
        {
            var result = await _tagService.Update(id, request);
            if (!result) return BadRequest();
            var response = new ApiResponse(success: true, message: "Success");

            return Ok(response);
        }
    }
}