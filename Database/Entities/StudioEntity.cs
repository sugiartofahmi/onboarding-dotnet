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
    [Table("studios")]
    public class Studio : Base, IStudio
    {
        [Required]
        public int StudioNumber { get; set; }

        [Required]
        public int SeatCapacity { get; set; }

        [JsonIgnore]
        public ICollection<MovieSchedule> MovieSchedules { get; } = new List<MovieSchedule>();

    }
}