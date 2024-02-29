using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.ViewComponents.LayoutComponents
{
    public class _LayoutMenuParticalComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}