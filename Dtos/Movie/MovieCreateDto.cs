using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace onboarding_backend.Dtos.Movie
{
    public class MovieCreateDto
    {
        [Required]
        public string Title { get; set; } = default!;

        [Required]
        public string Overview { get; set; } = default!;

        public string? Poster { get; set; }

        [Required]
        public DateTime PlayUntil { get; set; }
    }
}