using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Core.API
{
    public static class EntityFrameworkExtensions
    {
        public static void ConfigureSqlServer<DbContextType>(this WebApplicationBuilder builder) where DbContextType : DbContext
        {
            builder.Services.AddDbContext<DbContextType>(options =>
                 options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection")
                 .Replace("SA_PASSWORD", Environment.GetEnvironmentVariable("SA_PASSWORD"))));
        }
    }
}
