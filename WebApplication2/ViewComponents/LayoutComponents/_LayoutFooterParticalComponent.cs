using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.ViewComponents.LayoutComponents
{
    public class _LayoutFooterParticalComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}