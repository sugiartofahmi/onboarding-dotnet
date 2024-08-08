using onboarding_backend.Database.Entities;

namespace onboarding_backend.Interfaces
{
    public interface IMovieTag : IBase
    {
        public Movie Movie { get; set; }
        public Tag Tag { get; set; }
    }
}