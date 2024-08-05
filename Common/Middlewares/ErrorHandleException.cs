using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using onboarding_backend.Common.Responses;
using onboarding_backend.Dtos.Common;

namespace onboarding_backend.Common.Middlewares
{
    public class ErrorHandleException
    {
        private readonly ILogger<ErrorHandleException> _logger;
        private readonly RequestDelegate _next;

        public ErrorHandleException(ILogger<ErrorHandleException> logger, RequestDelegate next)
        {
            _logger = logger;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (UnauthorizedAccessException ex)
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                await WriteResponseAsync(context, ex.Message);
            }

            catch (NotFoundException ex)
            {
                context.Response.StatusCode = StatusCodes.Status404NotFound;
                await WriteResponseAsync(context, ex.Message);
            }

            catch (Exception ex)
            {
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                await WriteResponseAsync(context, ex.Message);
            }


        }

        private static async Task WriteResponseAsync(HttpContext context, String message)
        {
            context.Response.ContentType = "application/json";
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            await context.Response.WriteAsJsonAsync(new ApiResponse(success: false, message: message), options);
        }


    }
}