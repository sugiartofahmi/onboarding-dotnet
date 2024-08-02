using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using onboarding_backend.Interfaces;

namespace onboarding_backend.Dtos.Order
{
    public class OrderCreateDto
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public PaymentMethodEnum PaymentMethod { get; set; }

        [Required]
        public double TotalItemPrice { get; set; }
    }
}