using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.ViewComponents.LayoutComponents
{
    public class _LayoutHeaderParticalComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

         

            return View();
        }
    }
}