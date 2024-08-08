using onboarding_backend.Database.Entities;

namespace onboarding_backend.Interfaces
{
    public interface IOrder : IBase
    {
        public User User { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public double TotalItemPrice { get; set; }
        public ICollection<OrderItem> Items { get; }
    }
    public enum PaymentMethodEnum
    {
        Debit,
        Cash
    }
}