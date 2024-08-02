using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using onboarding_backend.Common.Responses;
using onboarding_backend.Dtos.Movie;
using onboarding_backend.Interfaces;
using onboarding_backend.Modules.Movie.Services;

namespace onboarding_backend.Modules.Movie.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class MovieController(MovieService movieService) : ControllerBase
    {
        private readonly MovieService _movieService = movieService;

        [HttpGet]
        public async Task<ActionResult<ApiResponse<PaginateResponse<IMovie>>>> Index()
        {
            var result = await _movieService.Pagination();
            return new ApiResponse<PaginateResponse<IMovie>>(data: result, success: true, message: "Success");

        }

        [HttpPost]
        public async Task<ActionResult<ApiResponse<string>>> Create([FromBody] MovieCreateDto request)
        {
            await _movieService.Create(request);
            var response = new ApiResponse<string>(success: true, message: "Success");

            return Ok(response);

        }
        [HttpGet("id")]
        public async Task<ActionResult<ApiResponse<IMovie>>> Detail(int id)
        {
            var result = await _movieService.FindOne(id);
            return new ApiResponse<IMovie>(data: result, success: true, message: "Success");
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _movieService.Delete(id);
            if (!result) return NotFound();
            var response = new ApiResponse<string>(success: true, message: "Success");

            return Ok(response);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] MovieUpdateDto request)
        {
            var result = await _movieService.Update(id, request);
            if (!result) return BadRequest();
            var response = new ApiResponse<string>(success: true, message: "Success");

            return Ok(response);
        }
    }
}