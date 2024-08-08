using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using onboarding_backend.Interfaces;

namespace onboarding_backend.Database.Entities
{
    [Table("movie_schedules")]
    public class MovieScheduleEntity : BaseEntity, IMovieSchedule
    {
        [Required]
        public int MovieId { get; set; }

        [JsonIgnore]
        public MovieEntity Movie { get; set; } = null!;

        [Required]
        public int StudioId { get; set; }
        public StudioEntity Studio { get; set; } = null!;

        [Required]
        public double Price { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string StartTime { get; set; } = string.Empty;

        [Required]
        public string EndTime { get; set; } = string.Empty;

        public List<OrderItemEntity> OrderItems { get; set; } = new List<OrderItemEntity>();
    }
}
