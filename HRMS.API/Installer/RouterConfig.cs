namespace HRMS.API.Installer
{
    public class RouterConfig(IEndpointRouteBuilder router)
    {
        private readonly IEndpointRouteBuilder _router = router;

        public void AddRouterConfig()
        {
            //_router.MapEmployeeEndpoints();
            //_router.MapLeaveEndpoints();
        }
    }
}
