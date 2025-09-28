using HRMS.API.Installer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi()
                .AddLogging()
                .InstallBackgroundService()
                .RegisterMiddleware()
                .RegisterCustomRouter();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

}

app.MapOpenApi("/docs");
app.UseCustomMiddleware();
app.UseCustomRouter();

app.Run();