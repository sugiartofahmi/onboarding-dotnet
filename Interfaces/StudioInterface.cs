
namespace onboarding_backend.Interfaces
{
    public interface IStudio : IBase
    {
        public int StudioNumber { get; set; }
        public int SeatCapacity { get; set; }
    }
}