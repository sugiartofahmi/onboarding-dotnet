using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using onboarding_backend.Common.Responses;
using onboarding_backend.Dtos.Tag;
using onboarding_backend.Interfaces;
using onboarding_backend.Modules.Tag.Repositories;

namespace onboarding_backend.Modules.Tag.Services
{
    public class TagService(TagRepository tagRepository)
    {
        private readonly TagRepository _tagRepository = tagRepository;

        public async Task<PaginateResponse<ITag>> Pagination()
        {
            return await _tagRepository.Pagination();
        }

        public async Task Create(TagCreateDto data)
        {
            await _tagRepository.Create(data);
        }

        public async Task<bool> Delete(int id)
        {
            var movie = await _tagRepository.FindOne(id);

            if (movie is null) return false;

            await _tagRepository.Delete(id);

            return true;
        }

        public async Task<bool> Update(int id, TagUpdateDto data)
        {
            var movie = await _tagRepository.FindOne(id);

            if (movie is null) return false;

            await _tagRepository.Update(movie, data);

            return true;
        }

        public async Task<ITag> FindOne(int id)
        {
            return await _tagRepository.FindOne(id);
        }

    }
}