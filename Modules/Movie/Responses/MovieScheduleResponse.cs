
namespace onboarding_backend.Modules.Schedule.Responses
{
    public class ScheduleResponse
    {
        public int Id { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public double Price { get; set; }
        public int StudioNumber { get; set; }
        public int SeatRemaining { get; set; }
    }
}