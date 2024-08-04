using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coravel.Queuing.Interfaces;
using Microsoft.EntityFrameworkCore;
using onboarding_backend.Database;
using onboarding_backend.Dtos.Movie;
using onboarding_backend.Modules.Movie.Repositories;
using onboarding_backend.Modules.Movie.Responses;

namespace onboarding_backend.Modules.Movie.Jobs
{
    public class MovieJob
    {
        private IQueue _queue;
        private readonly MovieRepository _movieRepository;
        private readonly ILogger<MovieJob> _logger;

        private readonly IServiceProvider _serviceProvider;

        public MovieJob(IQueue queue, MovieRepository movieRepository, ILogger<MovieJob> logger, IServiceProvider serviceProvider)
        {
            _queue = queue;
            _movieRepository = movieRepository;
            _logger = logger;
            _serviceProvider = serviceProvider;
        }

        public async Task<bool> Handle(TmdbMovieResponse data)
        {
            foreach (var item in data.Results)
            {

                using (var scope = _serviceProvider.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                    var movie = new MovieCreateDto
                    {
                        Title = item.Title,
                        Overview = item.Overview,
                        Poster = item.PosterPath,
                        PlayUntil = DateTime.Now
                    };

                    await _movieRepository.Create(movie);
                }
            }
            return true;
        }
    }
}