namespace HRMS.API.Installer
{
    public static class RouterConfig
    {
        public static void AddRouterConfig(this IServiceCollection services)
        {
            services.Scan(scan => scan
                    .FromAssemblyOf<IRegisterEndpoints>()
                    .AddClasses(classes => classes.AssignableTo<IRegisterEndpoints>())
                    .AsImplementedInterfaces()
                    .WithTransientLifetime());
        }

        public static void UseRouterConfig(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var endpoints = scope.ServiceProvider.GetServices<IRegisterEndpoints>();
            foreach (var ep in endpoints)
            {
                ep.RegisterEndpoints(app);
            }
        }
    }
}
