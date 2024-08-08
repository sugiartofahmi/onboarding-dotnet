using onboarding_backend.Common.Responses;
using onboarding_backend.Dtos.Common;
using onboarding_backend.Dtos.Schedule;
using onboarding_backend.Interfaces;
using onboarding_backend.Modules.Schedule.Repositories;

namespace onboarding_backend.Modules.Schedule.Services
{
    public class ScheduleService(ScheduleRepository scheduleRepository)
    {
        private readonly ScheduleRepository _scheduleRepository = scheduleRepository;

        public async Task Create(ScheduleCreateDto data)
        {
            await _scheduleRepository.Create(data);
        }

        public async Task<bool> Delete(int id)
        {
            var movie = await FindOne(id);

            if (movie is null)
                return false;

            await _scheduleRepository.Delete(id);

            return true;
        }

        public async Task<bool> Update(int id, ScheduleUpdateDto data)
        {
            var movie = await FindOne(id);

            if (movie is null)
                return false;

            await _scheduleRepository.Update(movie, data);

            return true;
        }

        public async Task<IMovieSchedule?> FindOne(int id)
        {
            return await _scheduleRepository.FindOne(id);
        }
    }
}
