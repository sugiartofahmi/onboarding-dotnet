using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using onboarding_backend.Interfaces;


namespace onboarding_backend.Database.Entities
{
    [Table("order_items")]
    public class OrderItem : Base, IOrderItem
    {
        [Required]
        public int OrderId { get; set; }

        [JsonIgnore]
        public Order Order { get; set; } = null!;

        [Required]
        public int MovieScheduleId { get; set; }
        [JsonIgnore]
        public MovieSchedule MovieSchedule { get; set; } = null!;

        [Required]
        public int Quantity { get; set; }

        [Required]
        public double SubTotalPrice { get; set; }

        [Required]
        public string Snapshots { get; set; }
    }
}