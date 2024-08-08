using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using onboarding_backend.Interfaces;


namespace onboarding_backend.Database.Entities
{
    [Table("studios")]
    public class StudioEntity : BaseEntity, IStudio
    {
        [Required]
        public int StudioNumber { get; set; }

        [Required]
        public int SeatCapacity { get; set; }

        [JsonIgnore]
        public ICollection<MovieScheduleEntity> MovieSchedules { get; } = new List<MovieScheduleEntity>();

    }
}