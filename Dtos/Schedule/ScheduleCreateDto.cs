using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace onboarding_backend.Dtos.Schedule
{
    public class ScheduleCreateDto
    {
        [Required(ErrorMessage = "Price tidak boleh kosong")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Movie Id tidak boleh kosong")]
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Studio Id tidak boleh kosong")]
        public int StudioId { get; set; }
    }
}