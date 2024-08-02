using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using onboarding_backend.Interfaces;
using onboarding_backend.Modules.Tag.Repositories;

namespace onboarding_backend.Modules.Tag.Services
{
    public class TagService(TagRepository tagRepository)
    {
        private readonly TagRepository _tagRepository = tagRepository;

        public async Task Delete(int id)
        {
            var tag = _tagRepository.FindOne(id);

            if (tag is null)
            {
                throw new Exception("Tag not found");
            }

            await _tagRepository.Delete((ITag)tag);
        }

        public async Task Create(ITag data)
        {
            await _tagRepository.Create(data);
        }

        public async Task Update(ITag data)
        {
            await _tagRepository.Update(data);
        }

        public async Task<ITag?> Detail(int id)
        {
            var tag = await _tagRepository.FindOne(id);
            if (tag is null)
            {
                throw new Exception("Tag not found");
            }
            return tag;
        }

    }
}