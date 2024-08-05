using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using onboarding_backend.Database.Entities;
using onboarding_backend.Interfaces;

namespace onboarding_backend.Modules.Order.Responses
{
    public class OrderIndexResponse
    {
        public int id { get; set; }
        public UserOrderResponse user { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public double TotalItemPrice { get; set; }
        public List<OrderItemResponse> Item { get; set; }

        public static OrderIndexResponse FromEntity(Database.Entities.Order order)
        {
            return new OrderIndexResponse
            {
                id = order.Id,
                user = order.User != null ? new UserOrderResponse
                {
                    Id = order.User.Id,
                    Name = order.User.Name
                } : null,
                PaymentMethod = order.PaymentMethod,
                TotalItemPrice = order.TotalItemPrice,
                Item = order?.Items?.Select(items => new OrderItemResponse
                {
                    Id = items.Id,
                    MovieScheduleId = items.MovieScheduleId,
                    Quantity = items.Quantity
                }).ToList() ?? new List<OrderItemResponse>()
            };
        }

        public static List<OrderIndexResponse> FromEntities(List<Database.Entities.Order> datas)
        {
            return datas.Select(FromEntity).ToList();
        }


    }

    public class OrderItemResponse
    {
        public int Id { get; set; }
        public int MovieScheduleId { get; set; }
        public int Quantity { get; set; }
    }

    public class UserOrderResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}