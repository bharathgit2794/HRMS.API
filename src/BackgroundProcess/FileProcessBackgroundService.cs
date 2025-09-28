namespace HRMS.API.BackgroundProcess
{
    public class FileProcessBackgroundService(ILogger<FileProcessBackgroundService> _ILogger)
        : BaseBackgroundService<FileProcessBackgroundService>(_ILogger)
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            string name = "bharathkrishnan";
            await ExecuteProcessAsync(() => ProcessMethod(name), stoppingToken);
        }

        public async Task ProcessMethod(string name)
        {
            Console.WriteLine($"Name :{name}");
            await Task.Delay(10000);
            throw new ArgumentNullException("Custom Exception Occur");
        }
    }
}
