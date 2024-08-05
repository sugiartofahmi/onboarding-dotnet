using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using onboarding_backend.Common.Responses;
using onboarding_backend.Dtos.Common;
using onboarding_backend.Dtos.Movie;
using onboarding_backend.Interfaces;
using onboarding_backend.Modules.Movie.Services;

namespace onboarding_backend.Modules.Movie.Controllers
{
    [Route("api/movies")]
    [ApiController]
    // [Authorize]
    public class MovieController(MovieService movieService) : ControllerBase
    {
        private readonly MovieService _movieService = movieService;

        [HttpGet]
        public async Task<ActionResult<ApiResponse>> Index([FromQuery] IndexDto request)
        {
            var result = await _movieService.Pagination(request);
            return new ApiResponse(data: result, success: true, message: "Success");

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse>> Detail(int id)
        {
            var result = await _movieService.FindOne(id);
            return new ApiResponse(data: result, success: true, message: "Success");
        }

    }
}