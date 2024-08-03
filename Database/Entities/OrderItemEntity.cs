using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using onboarding_backend.Interfaces;


namespace onboarding_backend.Database.Entities
{
    public class OrderItem : Base, IOrderItem
    {
        [Required]
        public int OrderId { get; set; }
        public Order Order { get; set; }

        [Required]
        public int MovieScheduleId { get; set; }
        public MovieSchedule MovieSchedule { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public double SubTotalPrice { get; set; }

        [Required]
        public string Snapshots { get; set; }
    }
}