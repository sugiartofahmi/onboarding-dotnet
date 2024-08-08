namespace onboarding_backend
{
    public static class Config
    {
        public static string JwtSecret { get; set; } = string.Empty;
        public static string JwtIssuer { get; set; } = string.Empty;
        public static string JwtAudience { get; set; } = string.Empty;
        public static string TmdbApiKey { get; set; } = string.Empty;
        public static string TmdbBaseUrl { get; set; } = string.Empty;
        public static string TmdbPosterUrl { get; set; } = string.Empty;
    }
}
