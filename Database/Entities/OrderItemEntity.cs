using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using onboarding_backend.Interfaces;


namespace onboarding_backend.Database.Entities
{
    public class OrderItem : Base, IOrderItem
    {
        public int OrderId { get; set; }
        public required Order Order { get; set; }

        public int MovieScheduleId { get; set; }
        public required MovieSchedule MovieSchedule { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double SubTotalPrice { get; set; }
        public string? Snapshots { get; set; }
    }
}