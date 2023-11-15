using PreparationForITExam.Core.Contracts;
using PreparationForITExam.Core.Services;
using PreparationForITExam.Infrastructure.Data.Common;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class PreparationForITExamServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IImageService, ImageService>();

            return services;
        }
    }
}
