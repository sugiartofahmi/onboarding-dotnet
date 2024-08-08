using onboarding_backend.Database.Entities;

namespace onboarding_backend.Interfaces
{
    public interface IMovieSchedule : IBase
    {
        public MovieEntity Movie { get; set; }
        public StudioEntity Studio { get; set; }
        public double Price { get; set; }



    }
}