using HRMS.API.Installer;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi("v1");
builder.Services.AddRouterConfig();
var app = builder.Build();

app.MapOpenApi();
app.MapScalarApiReference("/apidocs", options =>
{
    options.WithTitle("HRMS API");
});

app.UseRouterConfig();
app.Run();
