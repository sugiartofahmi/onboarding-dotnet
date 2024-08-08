using onboarding_backend.Database.Entities;
using onboarding_backend.Interfaces;
using onboarding_backend.Modules.Schedule.Responses;

namespace onboarding_backend.Modules.Movie.Responses
{
    public class MovieIndexResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public string Poster { get; set; }

        public List<Database.Entities.Tag> Tags { get; set; }
        public List<ScheduleResponse> Schedules { get; set; }

        public static MovieIndexResponse FromEntity(IMovie data)
        {
            return new MovieIndexResponse
            {
                Id = data.Id,
                Title = data.Title,
                Overview = data.Overview,
                Poster = data.Poster,
                Tags = data.Tags,
                Schedules = data.Schedules.Select(schedule => new ScheduleResponse
                {
                    Id = schedule.Id,
                    StartTime = schedule.StartTime,
                    EndTime = schedule.EndTime,
                    Price = schedule.Price,
                    StudioNumber = schedule.Studio.StudioNumber,
                    SeatRemaining = CalculateSeatRemaining(schedule)
                }).ToList()

            };
        }

        private static int CalculateSeatRemaining(MovieSchedule schedule)
        {
            int totalSeats = schedule.Studio.SeatCapacity;
            int bookedSeats = schedule.OrderItems?.Sum(order => order.Quantity) ?? 0;
            return totalSeats - bookedSeats;
        }
        public static List<MovieIndexResponse> FromEntities(List<IMovie> datas)
        {
            return datas.Select(FromEntity).ToList();
        }
    }
}