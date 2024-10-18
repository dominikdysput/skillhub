using LessonService.Data;
using LessonService.Helpers;
using LessonService.Interfaces;

namespace LessonService.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<LessonServiceDbContext>();
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);

            return services;
        }

    }
}
