using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetEnv;

namespace onboarding_backend
{
    public class Config
    {
        public static string ConnectionString;
        public static string TmdbApiKey;
        public static string TmdbBaseUrl;
        public static string TmdbPosterUrl;
        static Config()
        {
            DotNetEnv.Env.Load();
            ConnectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");
            TmdbApiKey = Environment.GetEnvironmentVariable("TMDB_API_KEY");
            TmdbBaseUrl = Environment.GetEnvironmentVariable("TMDB_BASE_URL");
            TmdbPosterUrl = Environment.GetEnvironmentVariable("TMDB_POSTER_URL");

        }
    }
}