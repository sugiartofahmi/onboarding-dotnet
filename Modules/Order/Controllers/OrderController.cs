using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using onboarding_backend.Common.Responses;
using onboarding_backend.Dtos.Order;
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
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId is null)
            {
                return Unauthorized();
            }
            await _orderService.Create(request, int.Parse(userId));
            var response = new ApiResponse(success: true, message: "Success");

            return Ok(response);
        }
    }
}
