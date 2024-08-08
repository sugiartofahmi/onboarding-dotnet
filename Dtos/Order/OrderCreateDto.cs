using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using onboarding_backend.Interfaces;

namespace onboarding_backend.Dtos.Order
{
    public class OrderCreateDto
    {

        [Required(ErrorMessage = "Payment Method tidak boleh kosong")]
        [EnumDataType(typeof(PaymentMethodEnum))]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PaymentMethodEnum PaymentMethod { get; set; }

        public List<OrderItemCreateDto> Items { get; set; }

    }

    public class OrderItemCreateDto
    {

        public int MovieScheduleId { get; set; }
        public int Quantity { get; set; }
    }
}