using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.ViewComponents.ExternalComponents
{
    public class _StatisticParticalComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}