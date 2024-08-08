using onboarding_backend.Database.Entities;

namespace onboarding_backend.Interfaces
{
    public interface IMovie : IBase
    {
        public string Title { get; set; }
        public string Overview { get; set; }
        public string Poster { get; set; }
        public DateTime PlayUntil { get; set; }
        public ICollection<MovieScheduleEntity> Schedules { get; }
        public List<TagEntity> Tags { get; }
    }
}