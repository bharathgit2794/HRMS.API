
namespace HRMS.API.Features.Employee
{
    public class EmployeeEndpoint(ILogger<EmployeeEndpoint> _ILogger) : IEndpoint
    {
        private readonly ILogger<EmployeeEndpoint> logger = _ILogger;

        public void MapRouteEndpoint(IEndpointRouteBuilder endpointRoute)
        {
            var endpointGroup = endpointRoute.MapGroup("employee");

            endpointGroup.MapGet("/{name}", GetEmployeeInformation);
        }

        public IResult GetEmployeeInformation(string name)
        {
           return Results.Ok($"{name} Hello");
        }
    }
}
