using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.OpenApi.Any;
using onboarding_backend.Modules.Movie.Repositories;
using onboarding_backend.Modules.Movie.Responses;

namespace onboarding_backend.Modules.Movie.Schedullers
{
    public class MovieScheduller : BackgroundService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<MovieScheduller> _logger;


        public MovieScheduller(
               IHttpClientFactory httpClientFactory,
        ILogger<MovieScheduller> logger)

        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;

        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Movie Scheduler running at: {time}", DateTimeOffset.Now);
                try
                {
                    var apiKey = Config.TmdbApiKey;
                    var client = _httpClientFactory.CreateClient();
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                    var response = await client.GetFromJsonAsync<TmdbMovieResponse>(Config.TmdbBaseUrl + "/movie/now_playing?language=en-US&page=1");
                    Console.WriteLine(response);

                    await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);
                }
                catch (Exception error)
                {
                    _logger.LogError(error, "An error occurred while running the Movie Scheduler");
                }
            }
        }


    }
}