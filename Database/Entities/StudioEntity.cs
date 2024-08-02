using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using onboarding_backend.Interfaces;


namespace onboarding_backend.Database.Entities
{
    public class Studio : Base, IStudio
    {
        public int StudioNumber { get; set; }
        public int SeatCapacity { get; set; }

        public List<MovieSchedule> MovieSchedules { get; set; }

    }
}