using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using onboarding_backend.Database.Entities;

namespace onboarding_backend.Interfaces
{
    public interface IOrder : IBase
    {
        public User User { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public double TotalItemPrice { get; set; }
        public List<OrderItem> Items { get; set; }
    }
    public enum PaymentMethodEnum
    {
        Debit,
        Cash
    }
}