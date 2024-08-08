using System.ComponentModel.DataAnnotations;

namespace onboarding_backend.Dtos.Schedule
{
    public class ScheduleCreateDto
    {
        [Required(ErrorMessage = "Price tidak boleh kosong")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Movie Id tidak boleh kosong")]
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Studio Id tidak boleh kosong")]
        public int StudioId { get; set; }

        [Required(ErrorMessage = "Date tidak boleh kosong")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Start Time tidak boleh kosong")]
        public string StartTime { get; set; }

        [Required(ErrorMessage = "End Time tidak boleh kosong")]
        public string EndTime { get; set; }
    }
}