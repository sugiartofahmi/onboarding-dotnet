using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using onboarding_backend.Interfaces;


namespace onboarding_backend.Database.Entities
{
    [Table("movie_schedules")]
    public class MovieSchedule : Base, IMovieSchedule
    {

        [Required]
        public int MovieId { get; set; }

        [JsonIgnore]
        public Movie Movie { get; set; } = null!;

        [Required]
        public int StudioId { get; set; }
        public Studio Studio { get; set; } = null!;

        [Required]
        public double Price { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string StartTime { get; set; }

        [Required]
        public string EndTime { get; set; }



        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    }
}