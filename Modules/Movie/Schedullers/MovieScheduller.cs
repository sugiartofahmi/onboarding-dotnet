using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.OpenApi.Any;
using onboarding_backend.Modules.Movie.Jobs;
using onboarding_backend.Modules.Movie.Repositories;
using onboarding_backend.Modules.Movie.Responses;

namespace onboarding_backend.Modules.Movie.Schedullers
{
    public class MovieScheduller : BackgroundService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<MovieScheduller> _logger;
        private readonly IServiceProvider _serviceProvider;

        public MovieScheduller(
               IHttpClientFactory httpClientFactory,
        ILogger<MovieScheduller> logger,
         IServiceProvider serviceProvider
        )

        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
            _serviceProvider = serviceProvider;

        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Movie Scheduler running");
                try
                {
                    var apiKey = Config.TmdbApiKey;
                    var client = _httpClientFactory.CreateClient();
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                    var response = await client.GetAsync(Config.TmdbBaseUrl + "/movie/now_playing?language=en-US&page=1");
                    response.EnsureSuccessStatusCode();
                    var content = await response.Content.ReadAsStringAsync();
                    var movieData = JsonSerializer.Deserialize<TmdbMovieResponse>(content);
                    using (var scope = _serviceProvider.CreateScope())
                    {
                        var movieJob = scope.ServiceProvider.GetRequiredService<MovieJob>();
                        await movieJob.Handle(movieData);
                    }

                    await Task.Delay(TimeSpan.FromSeconds(20), stoppingToken);
                }
                catch (Exception error)
                {
                    _logger.LogError(error, "An error occurred while running the Movie Scheduler");
                }
            }
        }


    }
}