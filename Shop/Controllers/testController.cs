using Microsoft.AspNetCore.Mvc;

namespace Shop.Controllers
{
    public class testController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
