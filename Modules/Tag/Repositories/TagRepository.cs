using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using onboarding_backend.Database;
using onboarding_backend.Interfaces;
using Sprache;

namespace onboarding_backend.Modules.Tag.Repositories
{
    public class TagRepository(AppDbContext context)
    {

        private readonly AppDbContext _context = context;
        public async Task<IActionResult> Pagination()
        {
            var response = new
            {
                success = true,
                data = await _context.Tags.ToListAsync()
            };
            return new ObjectResult(response);
        }

        public async Task<ITag?> FindOne(int id)
        {
            return await _context.Tags.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Create(ITag data)
        {
            _context.Tags.Add((Database.Entities.Tag)data);
            await _context.SaveChangesAsync();
        }

        public async Task Update(ITag data)
        {
            _context.Entry(data).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Delete(ITag data)
        {
            _context.Entry(data).State = EntityState.Deleted;
            var result = await _context.SaveChangesAsync();
            if (result == 0) return false;
            return true;
        }


    }
}