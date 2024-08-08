using onboarding_backend.Interfaces;

namespace onboarding_backend.Database.Entities
{
    public class Base : IBase
    {
        public int Id { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}