using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using onboarding_backend.Common.Responses;
using onboarding_backend.Database;
using onboarding_backend.Dtos.Tag;
using onboarding_backend.Interfaces;
using Sprache;

namespace onboarding_backend.Modules.Tag.Repositories
{
    public class TagRepository(AppDbContext context)
    {

        private readonly AppDbContext _context = context;
        public async Task<PaginateResponse<ITag>> Pagination()
        {
            var result = await _context.Tags.ToListAsync();
            return new PaginateResponse<ITag>
            {
                Items = result.Cast<ITag>().ToList()
            };
        }

        public async Task<ITag?> FindOne(int id)
        {
            return await _context.Tags.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Create(TagCreateDto data)
        {
            var tag = new Database.Entities.Tag
            {
                Name = data.Name
            };

            _context.Tags.Add(tag);
            await _context.SaveChangesAsync();
        }

        public async Task Update(ITag tag, TagUpdateDto data)
        {
            tag.Name = data.Name;

            _context.Entry(tag).State = EntityState.Modified;
            await _context.SaveChangesAsync();

        }

        public async Task Delete(int id)
        {
            await _context.Tags.Where(x => x.Id == id).ExecuteDeleteAsync();
        }


    }
}