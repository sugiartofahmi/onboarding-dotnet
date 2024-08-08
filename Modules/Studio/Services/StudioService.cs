using onboarding_backend.Common.Responses;
using onboarding_backend.Dtos.Common;
using onboarding_backend.Dtos.Studio;
using onboarding_backend.Interfaces;
using onboarding_backend.Modules.Studio.Repositories;

namespace onboarding_backend.Modules.Studio.Services
{
    public class StudioService(StudioRepository studioRepository)
    {
        private readonly StudioRepository _studioRepository = studioRepository;

        public async Task<PaginateResponse<IStudio>> Pagination(IndexDto request)
        {
            return await _studioRepository.Pagination(request);
        }

        public async Task Create(StudioCreateDto data)
        {
            await _studioRepository.Create(data);
        }

        public async Task<bool> Delete(int id)
        {
            var movie = await _studioRepository.FindOne(id);

            if (movie is null) return false;

            await _studioRepository.Delete(id);

            return true;
        }

        public async Task<bool> Update(int id, StudioUpdateDto data)
        {
            var movie = await _studioRepository.FindOne(id);

            if (movie is null) return false;

            await _studioRepository.Update(movie, data);

            return true;
        }

        public async Task<IStudio> FindOne(int id)
        {
            return await _studioRepository.FindOne(id);
        }

    }
}