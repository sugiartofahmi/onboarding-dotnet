using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using onboarding_backend.Common.Responses;
using onboarding_backend.Dtos.Common;
using onboarding_backend.Dtos.Order;
using onboarding_backend.Interfaces;
using onboarding_backend.Modules.Order.Repositories;

namespace onboarding_backend.Modules.Order.Services
{
    public class OrderService(OrderRepository orderRepository)
    {
        private readonly OrderRepository _orderRepository = orderRepository;

        public async Task<PaginateResponse<IOrder>> Pagination(IndexDto request)
        {
            return await _orderRepository.Pagination(request);
        }

        public async Task Create(OrderCreateDto data, int userId)
        {
            await _orderRepository.Create(data, userId);
        }

        public async Task<bool> Delete(int id)
        {
            var movie = await _orderRepository.FindOne(id);

            if (movie is null) return false;

            await _orderRepository.Delete(id);

            return true;
        }

        public async Task<bool> Update(int id, OrderUpdateDto data)
        {
            var movie = await _orderRepository.FindOne(id);

            if (movie is null) return false;

            await _orderRepository.Update(movie, data);

            return true;
        }

        public async Task<IOrder> FindOne(int id)
        {
            return await _orderRepository.FindOne(id);
        }

    }
}