using System.ComponentModel.DataAnnotations;

namespace onboarding_backend.Dtos.Studio

{
    public class StudioCreateDto
    {
        [Required(ErrorMessage = "Studio Number tidak boleh kosong")]
        public int StudioNumber { get; set; }

        [Required(ErrorMessage = "Seat Capacity tidak boleh kosong")]
        public int SeatCapacity { get; set; }
    }
}