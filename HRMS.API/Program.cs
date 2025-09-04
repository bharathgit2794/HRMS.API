using HRMS.API.Installer;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi("v1");
builder.Services.Scan(scan => scan
    .FromAssemblyOf<IRegisterEndpoints>()
    .AddClasses(classes => classes.AssignableTo<IRegisterEndpoints>())
    .AsImplementedInterfaces()
    .WithTransientLifetime());

var app = builder.Build();

app.MapOpenApi();
app.MapScalarApiReference("/apidocs", options =>
{
    options.WithTitle("HRMS API");
});

using var scope = app.Services.CreateScope();
var endpoints = scope.ServiceProvider.GetServices<IRegisterEndpoints>();

foreach (var ep in endpoints)
{
    ep.RegisterEndpoints(app);
}

app.Run();
