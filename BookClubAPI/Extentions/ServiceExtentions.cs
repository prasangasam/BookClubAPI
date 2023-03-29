using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;
using Repository;

namespace BookClubAPI.Extentions
{
    public static class ServiceExtentions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPloicy", builder => builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            });


        }

        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["ConnectionStrings:LocalDbConnection"];
            services.AddDbContext<RepositoryContext>(options => options.UseSqlServer(connectionString));

            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}
