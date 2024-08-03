using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using onboarding_backend.Interfaces;


namespace onboarding_backend.Database.Entities
{
    public class MovieTag : Base, IMovieTag
    {
        [Required]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [Required]
        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}