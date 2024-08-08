using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using onboarding_backend.Interfaces;


namespace onboarding_backend.Database.Entities
{
    [Table("orders")]
    public class OrderEntity : BaseEntity, IOrder
    {
        [Required]
        public int UserId { get; set; }
        public UserEntity User { get; set; } = null!;

        [Required]
        public PaymentMethodEnum PaymentMethod { get; set; }

        [Required]
        public double TotalItemPrice { get; set; }
        public ICollection<OrderItemEntity> Items { get; } = new List<OrderItemEntity>();
    }
}