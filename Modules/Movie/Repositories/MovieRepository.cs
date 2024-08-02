using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using onboarding_backend.Common.Interfaces;
using onboarding_backend.Common.Responses;
using onboarding_backend.Database;
using onboarding_backend.Dtos.Movie;
using onboarding_backend.Interfaces;
using Sprache;

namespace onboarding_backend.Modules.Movie.Repositories
{
    public class MovieRepository(AppDbContext context)
    {

        private readonly AppDbContext _context = context;
        public async Task<PaginateResponse<IMovie>> Pagination()
        {
            var result = await _context.Movies.ToListAsync();
            return new PaginateResponse<IMovie>
            {
                Items = result.Cast<IMovie>().ToList()
            };
        }



        public async Task<Database.Entities.Movie?> FindOne(int id)
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

            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Database.Entities.Movie movie, MovieUpdateDto data)
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

    }
}