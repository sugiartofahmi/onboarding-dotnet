using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace onboarding_backend.Dtos.Studio

{
    public class StudioCreateDto
    {
        [Required]
        public int StudioNumber { get; set; }

        [Required]
        public int SeatCapacity { get; set; }
    }
}