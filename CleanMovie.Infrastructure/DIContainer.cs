using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanMovie.Infrastructure
{
    public static class DIContainer
    {
        public static IServiceCollection ImplementPersistence(this
            IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<MovieDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(MovieDbContext).Assembly.FullName)),
                    ServiceLifetime.Transient);

            services.AddScoped<IMovieDbContext>(provider => provider.GetRequiredService<MovieDbContext>());
            
            return services;
        }
    }
}
