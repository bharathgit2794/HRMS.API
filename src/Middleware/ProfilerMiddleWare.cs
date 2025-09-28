
using System.Diagnostics;

namespace HRMS.API.Middleware
{
    public class ProfilerMiddleWare(ILogger<ProfilerMiddleWare> _ILogger) : IMiddleware
    {
        private readonly ILogger<ProfilerMiddleWare> logger = _ILogger;

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            await next.Invoke(context);
            stopwatch.Stop();

            logger.LogInformation("Profiler Middleware Info:");
        }
    }
}
