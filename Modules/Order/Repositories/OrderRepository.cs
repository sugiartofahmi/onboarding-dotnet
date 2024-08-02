using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using onboarding_backend.Common.Responses;
using onboarding_backend.Database;
using onboarding_backend.Dtos.Order;
using onboarding_backend.Dtos.Tag;
using onboarding_backend.Interfaces;

namespace onboarding_backend.Modules.Order.Repositories
{
    public class OrderRepository(AppDbContext context)
    {
        private readonly AppDbContext _context = context;
        public async Task<PaginateResponse<IOrder>> Pagination()
        {
            var result = await _context.Orders.ToListAsync();
            return new PaginateResponse<IOrder>
            {
                Items = result.Cast<IOrder>().ToList()
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