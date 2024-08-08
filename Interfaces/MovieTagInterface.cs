using onboarding_backend.Database.Entities;

namespace onboarding_backend.Interfaces
{
    public interface IMovieTag : IBase
    {
        public MovieEntity Movie { get; set; }
        public TagEntity Tag { get; set; }
    }
}