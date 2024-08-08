using Microsoft.EntityFrameworkCore;
using onboarding_backend.Common.Responses;
using onboarding_backend.Database;
using onboarding_backend.Database.Entities;
using onboarding_backend.Dtos.Common;
using onboarding_backend.Dtos.Order;
using onboarding_backend.Interfaces;
using onboarding_backend.Modules.Order.Responses;

namespace onboarding_backend.Modules.Order.Repositories
{
    public class OrderRepository(AppDbContext context, IHttpContextAccessor _httpContextAccessor)
    {
        private readonly IHttpContextAccessor _httpContextAccessor = _httpContextAccessor;
        private readonly AppDbContext _context = context;
        public async Task<PaginateResponse<OrderIndexResponse>> Pagination(IndexDto request)
        {
            var query = _context.Orders.Include(i => i.User).Include(i => i.Items).AsQueryable();
            var totalItems = await query.CountAsync();
            var totalPages = (int)Math.Ceiling(totalItems / (double)request.PerPage);
            var items = await query
       .Skip((request.Page - 1) * request.PerPage)
       .Take(request.PerPage)
       .ToListAsync();
            var httpContext = _httpContextAccessor.HttpContext;
            string baseUrl = $"{httpContext.Request.Scheme}://{httpContext.Request.Host}{httpContext.Request.PathBase}{httpContext.Request.Path}";
            return new PaginateResponse<OrderIndexResponse>
            {
                Items = OrderIndexResponse.FromEntities(items),
                Pagination = new PaginationMeta(page: request.Page,
                    perPage: request.PerPage,
                    totalItems: totalItems,
                    totalPages: totalPages,
                    baseUrl: baseUrl)
            };
        }

        public async Task<IOrder?> FindOne(int id)
        {
            return await _context.Orders.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Create(OrderCreateDto data, int userId)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                var order = new Database.Entities.Order
                {
                    UserId = userId,
                    PaymentMethod = data.PaymentMethod,
                    TotalItemPrice = 0
                };

                _context.Orders.Add(order);
                await _context.SaveChangesAsync();

                double totalItemPrice = 0;

                foreach (var item in data.Items)
                {
                    var movieSchedule = await _context.MovieSchedules
                        .FirstOrDefaultAsync(x => x.Id == item.MovieScheduleId);

                    if (movieSchedule == null)
                    {
                        throw new Exception($"MovieSchedule with ID {item.MovieScheduleId} not found.");
                    }

                    double subTotalPrice = movieSchedule.Price * item.Quantity;
                    var orderItem = new OrderItem
                    {
                        OrderId = order.Id,
                        MovieScheduleId = item.MovieScheduleId,
                        Quantity = item.Quantity,
                        SubTotalPrice = subTotalPrice,
                        Snapshots = ""
                    };
                    _context.OrderItems.Add(orderItem);
                    totalItemPrice += subTotalPrice;
                }

                order.TotalItemPrice = totalItemPrice;
                await _context.SaveChangesAsync();

                await transaction.CommitAsync();
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }

        }

        public async Task Update(IOrder order, OrderUpdateDto data)
        {
            order.PaymentMethod = data.PaymentMethod;


            _context.Entry(order).State = EntityState.Modified;
            await _context.SaveChangesAsync();

        }

        public async Task Delete(int id)
        {
            await _context.Orders.Where(x => x.Id == id).ExecuteDeleteAsync();
        }

    }
}