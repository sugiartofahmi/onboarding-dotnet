using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using onboarding_backend.Common.Responses;
using onboarding_backend.Dtos.Common;
using onboarding_backend.Dtos.Order;
using onboarding_backend.Interfaces;
using onboarding_backend.Modules.Order.Repositories;
using onboarding_backend.Modules.Order.Services;

namespace onboarding_backend.Modules.Transaction.Controllers
{
    [Route("api/backoffice/orders")]
    [ApiController]
    [Authorize]
    public class OrderBackofficeController(OrderService orderService) : ControllerBase
    {
        private readonly OrderService _orderService = orderService;
        [HttpGet]
        public async Task<ActionResult<ApiResponse>> Index([FromQuery] IndexDto request)
        {
            var result = await _orderService.Pagination(request);
            return new ApiResponse(data: result, success: true, message: "Success");

        }

        [HttpGet("id")]
        public async Task<ActionResult<ApiResponse>> Detail(int id)
        {
            var result = await _orderService.FindOne(id);
            return new ApiResponse(data: result, success: true, message: "Success");

        }
    }
}