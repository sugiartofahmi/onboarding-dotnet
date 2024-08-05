using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using onboarding_backend.Common.Responses;
using onboarding_backend.Database;
using onboarding_backend.Dtos.Common;
using onboarding_backend.Dtos.Order;
using onboarding_backend.Dtos.Tag;
using onboarding_backend.Interfaces;

namespace onboarding_backend.Modules.Order.Repositories
{
    public class OrderRepository(AppDbContext context, IHttpContextAccessor _httpContextAccessor)
    {
        private readonly IHttpContextAccessor _httpContextAccessor = _httpContextAccessor;
        private readonly AppDbContext _context = context;
        public async Task<PaginateResponse<IOrder>> Pagination(IndexDto request)
        {
            var query = _context.Orders.AsQueryable();
            var totalItems = await query.CountAsync();
            var totalPages = (int)Math.Ceiling(totalItems / (double)request.PerPage);
            var items = await query
       .Skip((request.Page - 1) * request.PerPage)
       .Take(request.PerPage)
       .ToListAsync();
            var httpContext = _httpContextAccessor.HttpContext;
            var baseUrl = $"{httpContext.Request.Scheme}://{httpContext.Request.Host}{httpContext.Request.PathBase}{httpContext.Request.Path}";

            return new PaginateResponse<IOrder>
            {
                Items = items.Cast<IOrder>().ToList(),
                Pagination = new PaginationMeta
                {
                    Page = request.Page,
                    PerPage = request.PerPage,
                    TotalItems = totalItems,
                    TotalPages = totalPages,
                    NextPageLink = request.Page < totalPages
                    ? $"{baseUrl}?Page={request.Page + 1}&PerPage={request.PerPage}"
                    : null,
                    PreviousPageLink = request.Page > 1
                    ? $"{baseUrl}?Page={request.Page - 1}&PerPage={request.PerPage}"
                    : null
                }
            };
        }

        public async Task<IOrder?> FindOne(int id)
        {
            return await _context.Orders.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Create(OrderCreateDto data)
        {
            var order = new Database.Entities.Order
            {
                UserId = data.UserId,
                PaymentMethod = data.PaymentMethod,
                TotalItemPrice = data.TotalItemPrice
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
        }

        public async Task Update(IOrder order, OrderUpdateDto data)
        {
            order.PaymentMethod = data.PaymentMethod;
            order.TotalItemPrice = data.TotalItemPrice;

            _context.Entry(order).State = EntityState.Modified;
            await _context.SaveChangesAsync();

        }

        public async Task Delete(int id)
        {
            await _context.Orders.Where(x => x.Id == id).ExecuteDeleteAsync();
        }

    }
}