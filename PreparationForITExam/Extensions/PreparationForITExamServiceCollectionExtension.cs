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
            services.AddScoped<ISchoolService, SchoolService>();
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<ISectionOfCurricularService, SectionOfCurricularService>();
            services.AddScoped<IModuleOfCurricularService, ModuleOfCurricularService>();
            services.AddScoped<ILessonService, LessonService>();
            services.AddScoped<IMaterialService, MaterialService>();
            services.AddScoped<IExerciseService, ExerciseService>();
            services.AddScoped<ILessonCommentService, LessonCommentService>();
            services.AddScoped<IChatService, ChatService>();
            services.AddScoped<IMessageService, MessageService>();

            return services;
        }
    }
}
