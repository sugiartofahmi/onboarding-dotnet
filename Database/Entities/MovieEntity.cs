using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using onboarding_backend.Interfaces;


namespace onboarding_backend.Database.Entities
{
    public class Movie : Base, IMovie
    {
        public required string Title { get; set; }
        public required string Overview { get; set; }
        public string? Poster { get; set; }
        public required DateTime PlayUntil { get; set; }
        public List<MovieSchedule> Schedules { get; set; }
        public List<MovieTag> Tags { get; set; }
    }
}