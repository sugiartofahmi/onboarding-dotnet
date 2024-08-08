using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using onboarding_backend.Interfaces;


namespace onboarding_backend.Database.Entities
{
    [Table("movies")]
    public class MovieEntity : BaseEntity, IMovie
    {

        [Required]
        public string Title { get; set; }

        [Required]
        public string Overview { get; set; }

        [Required]
        public string Poster { get; set; }

        [Required]
        public DateTime PlayUntil { get; set; }
        public ICollection<MovieScheduleEntity> Schedules { get; } = new List<MovieScheduleEntity>();
        public List<TagEntity> Tags { get; } = [];
    }
}