using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using onboarding_backend.Interfaces;


namespace onboarding_backend.Database.Entities
{
    public class Movie : Base, IMovie
    {

        [Required]
        public string Title { get; set; }

        [Required]
        public string Overview { get; set; }

        [Required]
        public string Poster { get; set; }

        [Required]
        public DateTime PlayUntil { get; set; }
        public ICollection<MovieSchedule> Schedules { get; } = new List<MovieSchedule>();
        public List<Tag> Tags { get; } = [];
    }
}