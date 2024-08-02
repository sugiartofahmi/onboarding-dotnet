using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using onboarding_backend.Database.Entities;

namespace onboarding_backend.Interfaces
{
    public interface IOrderItem : IBase
    {
        public Order Order { get; set; }
        public MovieSchedule MovieSchedule { get; set; }
        public int Quantity { get; set; }

        public double Price { get; set; }
        public double SubTotalPrice { get; set; }
        public string? Snapshots { get; set; }
    }
}