using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using onboarding_backend.Interfaces;

namespace onboarding_backend.Database.Entities
{
    [Table("users")]
    public class UserEntity : BaseEntity, IUser
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Avatar { get; set; }

        public bool IsAdmin { get; set; } = false;

        [JsonIgnore]
        public ICollection<OrderEntity>? Orders { get; } = new List<OrderEntity>();

    }
}