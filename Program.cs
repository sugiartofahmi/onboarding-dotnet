using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using onboarding_backend.Common.Middlewares;
using onboarding_backend.Database;

namespace onboarding_backend
{
    public partial class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var ConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            Config.JwtSecret = builder.Configuration.GetConnectionString("JWT:Secret")!;
            Config.JwtIssuer = builder.Configuration.GetConnectionString("JWT:Issuer")!;
            Config.JwtAudience = builder.Configuration.GetConnectionString("JWT:Audience")!;
            Config.TmdbApiKey = builder.Configuration.GetConnectionString("Tmdb:ApiKey")!;
            Config.TmdbBaseUrl = builder.Configuration.GetConnectionString("Tmdb:BaseUrl")!;
            Config.TmdbPosterUrl = builder.Configuration.GetConnectionString("Tmdb:PosterUrl")!;

            builder
                .Services.AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.PropertyNamingPolicy =
                        JsonNamingPolicy.SnakeCaseLower;
                    options.JsonSerializerOptions.DictionaryKeyPolicy =
                        JsonNamingPolicy.SnakeCaseLower;
                    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                });
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(ConnectionString);
            });
            builder.Services.AddAuthorization();
            builder
                .Services.AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme =
                        options.DefaultChallengeScheme =
                        options.DefaultForbidScheme =
                        options.DefaultScheme =
                        options.DefaultSignInScheme =
                        options.DefaultSignOutScheme =
                            JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(options =>
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
            builder.Services.AddSwaggerGen(option =>
            {
                option.AddSecurityDefinition(
                    "Bearer",
                    new OpenApiSecurityScheme
                    {
                        In = ParameterLocation.Header,
                        Description = "Please enter a valid token",
                        Name = "Authorization",
                        Type = SecuritySchemeType.Http,
                        BearerFormat = "JWT",
                        Scheme = "Bearer"
                    }
                );
                option.AddSecurityRequirement(
                    new OpenApiSecurityRequirement
                    {
                        {
                            new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                            },
                            new string[] { }
                        }
                    }
                );
            });

            //Partial class for configure services
            ConfigureServices(builder);

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
        }
    }
}
