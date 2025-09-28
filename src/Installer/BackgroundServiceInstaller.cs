using HRMS.API.BackgroundProcess;

namespace HRMS.API.Installer
{
    public static class BackgroundServiceInstaller
    {
        public static IServiceCollection InstallBackgroundService(this IServiceCollection services)
        {
            //services.AddHostedService<FileProcessBackgroundService>();

            return services;
        }
    }
}
