using Coravel;
using onboarding_backend.Modules.Auth.Repositories;
using onboarding_backend.Modules.Auth.Services;
using onboarding_backend.Modules.Movie.Jobs;
using onboarding_backend.Modules.Movie.Repositories;
using onboarding_backend.Modules.Movie.Schedullers;
using onboarding_backend.Modules.Movie.Services;
using onboarding_backend.Modules.Order.Repositories;
using onboarding_backend.Modules.Order.Services;
using onboarding_backend.Modules.Schedule.Repositories;
using onboarding_backend.Modules.Schedule.Services;
using onboarding_backend.Modules.Studio.Repositories;
using onboarding_backend.Modules.Studio.Services;
using onboarding_backend.Modules.Tag.Repositories;
using onboarding_backend.Modules.Tag.Services;

namespace onboarding_backend
{
    public partial class Program
    {
        public static void ConfigureServices(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<MovieService>();
            builder.Services.AddScoped<MovieRepository>();
            builder.Services.AddScoped<OrderService>();
            builder.Services.AddScoped<OrderRepository>();
            builder.Services.AddScoped<ScheduleService>();
            builder.Services.AddScoped<ScheduleRepository>();
            builder.Services.AddScoped<StudioService>();
            builder.Services.AddScoped<StudioRepository>();
            builder.Services.AddScoped<TagService>();
            builder.Services.AddScoped<TagRepository>();
            builder.Services.AddScoped<AuthService>();
            builder.Services.AddScoped<AuthRepository>();
            builder.Services.AddScoped<MovieJob>();
            builder.Services.AddHostedService<MovieScheduller>();
            builder.Services.AddQueue();
            builder.Services.AddHttpClient();
            builder.Services.AddHttpContextAccessor();
        }
    }
}