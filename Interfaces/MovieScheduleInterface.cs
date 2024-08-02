using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using onboarding_backend.Database.Entities;

namespace onboarding_backend.Interfaces
{
    public interface IMovieSchedule : IBase
    {
        public Movie Movie { get; set; }
        public Studio Studio { get; set; }
        public double Price { get; set; }
    }
}