using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using onboarding_backend.Common.Responses;
using onboarding_backend.Database;
using onboarding_backend.Database.Entities;
using onboarding_backend.Dtos.Common;
using onboarding_backend.Dtos.Schedule;
using onboarding_backend.Interfaces;

namespace onboarding_backend.Modules.Schedule.Repositories
{
    public class ScheduleRepository(AppDbContext context)
    {
        private readonly AppDbContext _context = context;
        public async Task<PaginateResponse<IMovieSchedule>> Pagination(IndexDto request)
        {
            var query = _context.MovieSchedules.AsQueryable();
            var totalItems = await query.CountAsync();
            var totalPages = (int)Math.Ceiling(totalItems / (double)request.PerPage);
            var items = await query
         .Skip((request.Page - 1) * request.PerPage)
         .Take(request.PerPage)
         .ToListAsync();
            return new PaginateResponse<IMovieSchedule>
            {
                Items = items.Cast<IMovieSchedule>().ToList(),
                Pagination = new PaginationMeta
                {
                    Page = request.Page,
                    PerPage = request.PerPage,
                    Total = totalItems,
                    TotalPages = totalPages
                }
            };
        }

        public async Task<IMovieSchedule?> FindOne(int id)
        {
            return await _context.MovieSchedules.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Create(ScheduleCreateDto data)
        {
            var schedule = new MovieSchedule
            {
                Price = data.Price,
                MovieId = data.MovieId,
                StudioId = data.StudioId
            };

            _context.MovieSchedules.Add(schedule);
            await _context.SaveChangesAsync();
        }

        public async Task Update(IMovieSchedule movieSchedule, ScheduleUpdateDto data)
        {
            movieSchedule.Price = data.Price;

            _context.Entry(movieSchedule).State = EntityState.Modified;
            await _context.SaveChangesAsync();

        }

        public async Task Delete(int id)
        {
            await _context.Tags.Where(x => x.Id == id).ExecuteDeleteAsync();
        }

    }
}