using HRMS.API.Middleware;

namespace HRMS.API.Installer
{
    public static class MiddlewareInstaller
    {
        public static IServiceCollection RegisterMiddleware(this IServiceCollection services)
        {
            services.AddTransient<ProfilerMiddleWare>();

            return services;
        }


        public static void UseCustomMiddleware(this WebApplication application)
        {
            application.UseMiddleware<ProfilerMiddleWare>();
        }
    }
}
