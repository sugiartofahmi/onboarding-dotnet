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