using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using onboarding_backend.Database.Entities;

namespace onboarding_backend.Interfaces
{
    public interface IMovie : IBase
    {
        public string Title { get; set; }
        public string Overview { get; set; }
        public string Poster { get; set; }
        public DateTime PlayUntil { get; set; }
        public ICollection<MovieSchedule> Schedules { get; }
        public List<Tag> Tags { get; }
    }
}