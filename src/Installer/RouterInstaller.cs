using HRMS.API.Features;
using Scrutor;

namespace HRMS.API.Installer
{
    public static class RouterInstaller
    {
        public static IServiceCollection RegisterCustomRouter(this IServiceCollection services)
        {
            services.Scan(item => item.FromAssemblyOf<IEndpoint>()
                                       .AddClasses(cls => cls.AssignableTo<IEndpoint>())
                                       .AsImplementedInterfaces()
                                       .WithSingletonLifetime());

            return services;
        }

        public static void UseCustomRouter(this WebApplication application)
        {
            foreach (var endpoint in application.Services.GetServices<IEndpoint>())
            {
                endpoint.MapRouteEndpoint(application);
            }
        }
    }
}
