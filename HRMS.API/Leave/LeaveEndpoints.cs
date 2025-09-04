using HRMS.API.Installer;

namespace HRMS.API
{
    public class LeaveEndpoints() : IRegisterEndpoints
    {
        public void RegisterEndpoints(IEndpointRouteBuilder router)
        {
            var employeeRouter = router.MapGroup("leave");

            employeeRouter.MapGet("/", () => "List of leave");
        }
    }
}
