using HRMS.API.Installer;

namespace HRMS.API
{
    public class EmployeeEndpoints() : IRegisterEndpoints
    {
        public void RegisterEndpoints(IEndpointRouteBuilder router)
        {
            var employeeRouter = router.MapGroup("employees");

            employeeRouter.MapGet("/", () => "List of employees");
        }
    }
}
