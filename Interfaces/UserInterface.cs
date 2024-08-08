using onboarding_backend.Database.Entities;

namespace onboarding_backend.Interfaces
{
    public interface IUser : IBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Avatar { get; set; }

        public ICollection<Order> Orders { get; }
    }
}