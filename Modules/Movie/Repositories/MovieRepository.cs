using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using onboarding_backend.Common.Interfaces;
using onboarding_backend.Common.Requests;
using onboarding_backend.Common.Responses;
using onboarding_backend.Database;
using onboarding_backend.Dtos.Common;
using onboarding_backend.Dtos.Movie;
using onboarding_backend.Interfaces;
using Sprache;

namespace onboarding_backend.Modules.Movie.Repositories
{
    public class MovieRepository(AppDbContext context)
    {

        private readonly AppDbContext _context = context;
        public async Task<PaginateResponse<IMovie>> Pagination(IndexDto request)
        {
            var query = _context.Movies.AsQueryable();
            if (request.Search != null)
            {
                query = query.Where(i => EF.Functions.Like(i.Title, "%" + request.Search + "%"));
            }

            var totalItems = await query.CountAsync();
            var totalPages = (int)Math.Ceiling(totalItems / (double)request.PerPage);

            var items = await query
           .Skip((request.Page - 1) * request.PerPage)
           .Take(request.PerPage)
           .ToListAsync();

            return new PaginateResponse<IMovie>
            {
                Items = items.Cast<IMovie>().ToList(),
                Pagination = new PaginationMeta
                {
                    Page = request.Page,
                    PerPage = request.PerPage,
                    Total = totalItems,
                    TotalPages = totalPages
                }
            };
        }



        public async Task<IMovie?> FindOne(int id)
        {
            return await _context.Movies.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Create(MovieCreateDto data)
        {
            var movie = new Database.Entities.Movie
            {
                Title = data.Title,
                Overview = data.Overview,
                Poster = data.Poster,
                PlayUntil = data.PlayUntil
            };

            _context.Entry(movie).State = EntityState.Added;
            await _context.SaveChangesAsync();
        }

        public async Task Update(IMovie movie, MovieUpdateDto data)
        {
            movie.Title = data.Title;
            movie.Overview = data.Overview;
            movie.Poster = data.Poster;
            movie.PlayUntil = data.PlayUntil;

            _context.Entry(movie).State = EntityState.Modified;
            await _context.SaveChangesAsync();

        }

        public async Task Delete(int id)
        {
            await _context.Movies.Where(x => x.Id == id).ExecuteDeleteAsync();
        }

        public async Task<List<Database.Entities.Movie>> FindAll()
        {
            return await _context.Movies.ToListAsync();
        }

    }
}