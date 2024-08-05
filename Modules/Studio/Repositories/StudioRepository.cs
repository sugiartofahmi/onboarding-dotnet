using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using onboarding_backend.Common.Responses;
using onboarding_backend.Database;
using onboarding_backend.Dtos.Common;
using onboarding_backend.Dtos.Studio;
using onboarding_backend.Dtos.Tag;
using onboarding_backend.Interfaces;
using Sprache;

namespace onboarding_backend.Modules.Studio.Repositories
{
    public class StudioRepository(AppDbContext context)
    {

        private readonly AppDbContext _context = context;
        public async Task<PaginateResponse<IStudio>> Pagination(IndexDto request)
        {
            var query = _context.Studios.AsQueryable();
            var totalItems = await query.CountAsync();
            var totalPages = (int)Math.Ceiling(totalItems / (double)request.PerPage);

            var items = await query
           .Skip((request.Page - 1) * request.PerPage)
           .Take(request.PerPage)
           .ToListAsync();

            return new PaginateResponse<IStudio>
            {
                Items = items.Cast<IStudio>().ToList(),
                Pagination = new PaginationMeta
                {
                    Page = request.Page,
                    PerPage = request.PerPage,
                    Total = totalItems,
                    TotalPages = totalPages
                }
            };
        }

        public async Task<IStudio?> FindOne(int id)
        {
            return await _context.Studios.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Create(StudioCreateDto data)
        {
            var studio = new Database.Entities.Studio
            {
                StudioNumber = data.StudioNumber,
                SeatCapacity = data.SeatCapacity
            };

            _context.Studios.Add(studio);
            await _context.SaveChangesAsync();
        }

        public async Task Update(IStudio studio, StudioUpdateDto data)
        {
            studio.StudioNumber = data.StudioNumber;
            studio.SeatCapacity = data.SeatCapacity;

            _context.Entry(studio).State = EntityState.Modified;
            await _context.SaveChangesAsync();

        }

        public async Task Delete(int id)
        {
            await _context.Studios.Where(x => x.Id == id).ExecuteDeleteAsync();
        }


    }
}