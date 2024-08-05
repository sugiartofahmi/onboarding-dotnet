using System.Text.Json;
using Coravel;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using onboarding_backend;
using onboarding_backend.Common.Middlewares;
using onboarding_backend.Common.Utils;
using onboarding_backend.Database;
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

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower;
    options.JsonSerializerOptions.DictionaryKeyPolicy = JsonNamingPolicy.SnakeCaseLower;

});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(option =>
{
    option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter a valid token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });
    option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
        }
    });
});
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(Config.ConnectionString);
});
builder.Services.AddAuthorization();
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme =
    options.DefaultChallengeScheme =
    options.DefaultForbidScheme =
    options.DefaultScheme =
    options.DefaultSignInScheme =
    options.DefaultSignOutScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidIssuer = Config.JwtIssuer,
        ValidateAudience = true,
        ValidAudience = Config.JwtAudience,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(
            System.Text.Encoding.UTF8.GetBytes(Config.JwtSecret)
        )
    };
});

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
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.UseMiddleware<ErrorHandleException>();
app.MapControllers();
app.Run();

