using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace onboarding_backend.Dtos.Schedule
{
    public class ScheduleCreateDto
    {
        [Required]
        public double Price { get; set; }

        public int MovieId { get; set; }

        public int StudioId { get; set; }
    }
}