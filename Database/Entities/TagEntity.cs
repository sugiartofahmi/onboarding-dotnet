using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using onboarding_backend.Interfaces;

namespace onboarding_backend.Database.Entities
{
    [Table("tags")]
    public class Tag : Base, ITag
    {
        [Required]
        public string Name { get; set; }

        [JsonIgnore]
        public List<Movie> Movies { get; } = [];

    }
}