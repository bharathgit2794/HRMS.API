namespace HRMS.API.BackgroundProcess
{
    public abstract class BaseBackgroundService<TEntity>(ILogger<TEntity> _ILogger)
        : BackgroundService
    {
        private readonly ILogger<TEntity> logger = _ILogger;

        protected async Task ExecuteProcessAsync(Func<Task> task, CancellationToken stoppingToken)
        {
            try
            {
                await task();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
                await Task.Delay(10000);
                await ExecuteAsync(stoppingToken);
            }
        }
    }
}
