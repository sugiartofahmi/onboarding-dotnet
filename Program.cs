using Microsoft.EntityFrameworkCore;
using onboarding_backend;
using onboarding_backend.Database;
using onboarding_backend.Modules.Movie.Repositories;
using onboarding_backend.Modules.Movie.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(Config.ConnectionString);
});
builder.Services.AddScoped<MovieService>();
builder.Services.AddScoped<MovieRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();

