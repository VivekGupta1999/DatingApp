using System;
using API.Data;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
	public static class ApplicationsServicesExtensions
	{
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });
            services.AddScoped<ITokenService, TokenService>();

            return services;
        }
	}
}

