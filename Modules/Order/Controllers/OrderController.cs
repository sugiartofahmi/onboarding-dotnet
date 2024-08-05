using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
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
    [Route("api/orders")]
    [ApiController]
    [Authorize]
    public class OrderController(OrderService orderService) : ControllerBase
    {
        private readonly OrderService _orderService = orderService;

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] OrderCreateDto request)
        {
            int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            await _orderService.Create(request, userId);
            var response = new ApiResponse(success: true, message: "Success");

            return Ok(response);

        }


    }
}