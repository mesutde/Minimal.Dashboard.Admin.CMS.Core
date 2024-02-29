using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }
    }
}