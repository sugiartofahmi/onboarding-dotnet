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
        [Required(ErrorMessage = "User Id tidak boleh kosong")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Payment Method tidak boleh kosong")]
        public PaymentMethodEnum PaymentMethod { get; set; }

        [Required(ErrorMessage = "Total Item Price tidak boleh kosong")]
        public double TotalItemPrice { get; set; }
    }
}