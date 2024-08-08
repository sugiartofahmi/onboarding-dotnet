using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using onboarding_backend.Interfaces;


namespace onboarding_backend.Database.Entities
{
    [Table("orders")]
    public class Order : Base, IOrder
    {
        [Required]
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        [Required]
        public PaymentMethodEnum PaymentMethod { get; set; }

        [Required]
        public double TotalItemPrice { get; set; }
        public ICollection<OrderItem> Items { get; } = new List<OrderItem>();
    }
}