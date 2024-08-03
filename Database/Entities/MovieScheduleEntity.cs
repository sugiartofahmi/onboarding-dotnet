using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using onboarding_backend.Interfaces;


namespace onboarding_backend.Database.Entities
{
    public class MovieSchedule : Base, IMovieSchedule
    {
        [Required]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [Required]
        public int StudioId { get; set; }
        public Studio Studio { get; set; }

        [Required]
        public double Price { get; set; }

    }
}