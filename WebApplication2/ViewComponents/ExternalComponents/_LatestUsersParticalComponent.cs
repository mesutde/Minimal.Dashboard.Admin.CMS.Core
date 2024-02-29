using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.ViewComponents.ExternalComponents
{
    public class _LatestUsersParticalComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}