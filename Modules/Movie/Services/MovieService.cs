using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using onboarding_backend.Common.Responses;
using onboarding_backend.Dtos.Movie;
using onboarding_backend.Interfaces;
using onboarding_backend.Modules.Movie.Repositories;

namespace onboarding_backend.Modules.Movie.Services
{
    public class MovieService(MovieRepository movieRepository)
    {
        private readonly MovieRepository _movieRepository = movieRepository;

        public async Task<PaginateResponse<IMovie>> Pagination()
        {
            return await _movieRepository.Pagination();
        }

        public async Task Create(MovieCreateDto data)
        {
            await _movieRepository.Create(data);
        }

        public async Task<bool> Delete(int id)
        {
            var movie = await _movieRepository.FindOne(id);

            if (movie is null) return false;

            await _movieRepository.Delete(id);

            return true;
        }

        public async Task<bool> Update(int id, MovieUpdateDto data)
        {
            var movie = await _movieRepository.FindOne(id);

            if (movie is null) return false;

            await _movieRepository.Update(movie, data);

            return true;
        }
    }
}